using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Net;
using System.Web;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Arena
{


    public class ArenaClient
    {
        public enum ReqVerb { GET, POST, PUT, DELETE }

        private string m_errMsg = "";
        public string ErrMsg { get => m_errMsg; set => m_errMsg = value; }

        //Supply following three parameters to log into Arena
        private string m_loginID = "";
        private string m_password = "";
        private string m_workspaceID = "";
        public string WorkspaceID { get => m_workspaceID; set => m_workspaceID = value; }

        //Store the following credential once obtained from server
        private string m_sessionID = "";
        public string SessionID { get => m_sessionID; set => m_sessionID = value; }

        private string m_workspaceName = "";
        public string WorkspaceName { get => m_workspaceName; set => m_workspaceName = value; }
        //Arena API URL Endpoints
        private const string m_URL_Base = "https://api.arenasolutions.com/v1/";   //Base URL for Arena API
        private string m_URL_Login = m_URL_Base + "login";
        private string m_URL_Logout = m_URL_Base + "logout";
        private string m_URL_Items = m_URL_Base + "items";
        private string m_URL_SupplierItems = m_URL_Base + "supplieritems";
        private string m_requestResultCode = "";
        /// <summary>
        /// HTTP Status code obtained as a result of executing an API Request
        /// </summary>
        public string ResultCode { get => m_requestResultCode; set => m_requestResultCode = value; }

        private string m_requestResultDescription = "";
        /// <summary>
        /// Description of the Status Code
        /// </summary>
        public string ResultDescription { get => m_requestResultDescription; set => m_requestResultDescription = value; }
        

        private string m_jsonResp = "";
        /// <summary>
        /// JSON Response of an API Call
        /// </summary>
        public string JsonResp { get => m_jsonResp; set => m_jsonResp = value; }
 



        //JSON Serialization settings
        /// <summary>
        /// Use JSS to ignore Null Values and Default Values
        /// </summary>
        public JsonSerializerSettings JSS =
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore

            };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="loginID">Log ID</param>
        /// <param name="pwd">Password for LoginID</param>
        /// <param name="workspaceID">Workspace ID in which to log in.  If left blank, Arena will log you in to the most recent workspace.</param>
        public ArenaClient(string loginID, string pwd, string workspaceID)
        {
            try
            {
                m_loginID = loginID;
                m_password = pwd;
                WorkspaceID = workspaceID;


            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message + ex.StackTrace;
            }
        }

        private HttpWebResponse res;
        private HttpWebRequest req;
        /// <summary>
        /// Executes an API Call
        /// </summary>
        /// <param name="apiURL">URL endpoint against which to execute the Request</param>
        /// <param name="reqType">Request Type (GET/POST/PUT/DELETE)-- use Enum ReqVerb</param>
        /// <param name="dataPayload">Data to send with request; usually used for POST requests</param>
        /// <param name="blIncludeAccessTokenInHeader">Leave TRUE to include the Session ID that was obtained during login in the Request Header.
        /// Basically, this gets set false only when logging in (validation), since the Session ID is unknown</param>
        /// <param name="contentType"></param>
        /// <param name="lstReqHeader">Additional parameters to add to header; format of each list element is [NAME]:[VALUE]</param>
        /// <returns></returns>
        public string ExecuteAPICall(string apiURL,
                                    ReqVerb reqType,
                                    string dataPayload,
                                    Boolean blIncludeAccessTokenInHeader = true,
                                    string contentType = "application/json",
                                    List<string> lstReqHeader = null)
        {
            

            try
            {
                m_requestResultCode = "";
                m_requestResultDescription = "";
                string verb = "";
                switch (reqType)
                {
                    case ReqVerb.DELETE:
                        verb = "DELETE";
                        break;
                    case ReqVerb.GET:
                        verb = "GET";
                        break;
                    case ReqVerb.POST:
                        verb = "POST";
                        break;
                    case ReqVerb.PUT:
                        verb = "PUT";
                        break;
                }
                string strReq = apiURL;
                req = (HttpWebRequest)WebRequest.Create(apiURL);
                //Add the data payload to the request:
                req.Method = verb;
                req.KeepAlive = true;

                //add data to the request, if needed
                if (dataPayload != "")
                {
                    req.ContentType = contentType;
                    switch (contentType)
                    {
                        case "application/x-www-form-urlencoded":
                            byte[] byteData = Encoding.UTF8.GetBytes(dataPayload);
                            using (Stream reqStream = req.GetRequestStream())
                            {
                                reqStream.Write(byteData, 0, byteData.Length);
                                reqStream.Close();
                            }
                            break;
                        case "application/json":
                            using (StreamWriter sW = new StreamWriter(req.GetRequestStream()))
                            {
                                sW.Write(dataPayload);
                                sW.Flush();
                                sW.Close();
                            }
                            break;
                    }

                }

                //Add token header, if required
                if (blIncludeAccessTokenInHeader)
                {
                    req.Headers.Add("arena_session_id: " + m_sessionID);
                }

                //Add additional headers, if required
                if (lstReqHeader != null)
                {
                    for (int i = 0; i < lstReqHeader.Count; i++)
                    {
                        req.Headers.Add(lstReqHeader[i]);
                    }
                }
                res = (HttpWebResponse)req.GetResponse();
                m_requestResultCode = res.StatusCode.ToString();
                m_requestResultDescription = res.StatusDescription;
                using (Stream webStream = res.GetResponseStream())
                {
                    StreamReader webStreamReader = new StreamReader(webStream);
                    return webStreamReader.ReadToEnd();
                }

            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errResp = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errResp.GetResponseStream()))
                        {
                            ErrMsg = reader.ReadToEnd();
                            return "Error: " + ErrMsg;
                        }
                    }
                } else
                {
                    return "Error: WebException with null Response (?)";
                }
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message + ex.StackTrace;
                return "Error: " + ErrMsg;
            }
        }

        /// <summary>
        /// Logs into arena, and returns the JSON repsonse.
        /// Before returning, this method parses the JSON response and stores
        /// *the arena_session_id
        /// *the arena workspace name
        /// *the workspace ID (if current workspace ID was unintialized) 
        /// ...in an internal properties of this object.
        /// </summary>
        /// <returns></returns>
        public string Login()
        {
            try
            {
                LogInCredential lic = new LogInCredential(m_loginID, m_password, WorkspaceID);
                string jsonLic = JsonConvert.SerializeObject(lic, JSS);
                string resp = ExecuteAPICall(m_URL_Login, ReqVerb.POST, jsonLic, false);
                if (resp.ToLower().StartsWith("error"))
                {
                    return resp;
                }
                JObject jO = JObject.Parse(resp);
                m_sessionID = jO["arenaSessionId"].ToString();
                m_workspaceName = jO["workspaceName"].ToString();
                if (m_workspaceID == "")
                {
                    m_workspaceID = jO["workspaceID"].ToString();
                }
                return resp;
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message + ex.StackTrace;
                return "Error: " + ErrMsg;
            }
        }

        public Boolean Logout()
        {
            try
            {
                string result = ExecuteAPICall(m_URL_Logout, ReqVerb.PUT, "");

                if (result.ToLower().Contains("error"))
                {
                    return false;
                } else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                m_errMsg = ex.Message + ex.StackTrace;
                return false;
            }
        }

        /// <summary>
        /// Returns an Item Search Results object based on the suplied search parameters.
        /// Use the '*' character as a wildcard in string searches
        /// </summary>
        /// <param name="offset">Specifies position in list of items where results begin</param>
        /// <param name="limit">Specifies number of results to return; leave blank for default of 20.  Max value is 200</param>
        /// <param name="categoryGUID">Category Unique ID</param>
        /// <param name="creatorFullName">Full Name of creator</param>
        /// <param name="creatorGUID">GUID of creator</param>
        /// <param name="name">Item name</param>
        /// <param name="number">Item Number</param>
        /// <param name="revNumber">Item Revision Number</param>
        /// <param name="desc">Item Description</param>
        /// <param name="ownerFullName">Full Name of item owner</param>
        /// <param name="effDateFrom">Date revision of item was made effective</param>
        /// <param name="effDateTo">Date revision of item was superseded</param>
        /// <param name="lifeCyclePhaseGUID">GUID of LifeCyclePhase</param>
        /// <param name="modifiedBOM">true or false; indicates whether BOM of item includes modifications to working revision</param>
        /// <param name="modifiedFiles">true or false; indicates if the Files view of the item includes modifications to the working revision</param>
        /// <param name="modifiedSourcing">true or false; indicates if the Sourcing view of the item includes modifications to the working revision</param>
        /// <param name="modifiedSpecs">true or false; indicates if the Specs view of the tiem includes modifications to the working revision</param>
        /// <returns></returns>
        public SearchResultsItem SearchItem(int offset = -1,
                                 int limit = -1,
                                 string categoryGUID = "",
                                 string creatorFullName = "",
                                 string creatorGUID = "",
                                 string name = "",
                                 string number="",
                                 string revNumber = "",
                                 string desc = "",
                                 string ownerFullName = "",
                                 string effDateFrom = "",
                                 string effDateTo = "",
                                 string lifeCyclePhaseGUID = "",
                                 string modifiedBOM = "",
                                 string modifiedFiles = "",
                                 string modifiedSourcing = "",
                                 string modifiedSpecs = "")
        {
            try
            {
                //Construct the query string for the GET query
                StringBuilder sB = new StringBuilder();
                sB.Append("?");
                if (offset>-1)
                {
                    sB.Append("offset=" + offset.ToString() + "&");
                }
                if (limit > -1)
                {
                    sB.Append("limit=" + limit.ToString() + "&");
                }
                if (categoryGUID != "")
                {
                    sB.Append("category.guid=" + categoryGUID + "&");
                }
                if (creatorFullName != "")
                {
                    sB.Append("creator.fullName=" + creatorFullName + "&");
                }
                if (creatorGUID != "")
                {
                    sB.Append("creator.guid=" + creatorGUID + "&");
                }
                if (name != "")
                {
                    sB.Append("name=" + name + "&");
                }
                if (number != "")
                {
                    sB.Append("number=" + number + "&");
                }
                if (revNumber != "")
                {
                    sB.Append("revisionNumber=" + revNumber + "&");
                }
                if (desc != "")
                {
                    sB.Append("description=" + desc + "&");
                }
                if (ownerFullName != "")
                {
                    sB.Append("owner.fullName=" + ownerFullName + "&");
                }
                if (effDateFrom != "")
                {
                    sB.Append("effectiveDateFrom=" + effDateFrom + "&");
                }
                if (effDateTo != "")
                {
                    sB.Append("effectiveDateTo=" + effDateTo + "&");
                }
                if (lifeCyclePhaseGUID != "")
                {
                    sB.Append("lifecyclePhase.guid=" + lifeCyclePhaseGUID + "&");
                }
                if (modifiedBOM != "")
                {
                    sB.Append("modifiedBom=" + modifiedBOM + "&");
                }
                if (modifiedFiles != "")
                {
                    sB.Append("modifiedFiles=" + modifiedFiles + "&");
                }
                if (modifiedSourcing != "")
                {
                    sB.Append("modifiedSourcing=" + modifiedSourcing + "&");
                }
                if (modifiedSpecs != "")
                {
                    sB.Append("modifiedSpecs=" + modifiedSpecs + "&");
                }
                string searchURL = m_URL_Items;
                if (sB.Length>1)
                { 
                    searchURL = searchURL + sB.ToString().Substring(0, sB.ToString().Length - 1);
                }
                m_jsonResp = ExecuteAPICall(searchURL, ReqVerb.GET, "");
                return JsonConvert.DeserializeObject<SearchResultsItem>(m_jsonResp);
            } catch (Exception ex)
            {
                m_errMsg = m_errMsg + ex.Message + ex.StackTrace;
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset">Specifies position in list of items where results begin</param>
        /// <param name="limit">Specifies number of results to return; leave blank for default of 20.  Max value is 200</param>
        /// <param name="name">Supplier Item Name</param>
        /// <param name="number">Supplier Item Number</param>
        /// <param name="supplierName">Name of supplier whose items you want</param>
        /// <param name="supplierGUID">GUID of supplier whose items you want</param>
        /// <returns></returns>
        public SearchResultsSupplierItem SearchSupplierItem(int offset = -1,
                         int limit = -1,
                         string name = "",
                         string number = "",
                         string supplierName = "",
                         string supplierGUID = "")
        {
            try
            {
                //Construct the query string for the GET query
                StringBuilder sB = new StringBuilder();
                sB.Append("?");
                if (offset > -1)
                {
                    sB.Append("offset=" + offset.ToString() + "&");
                }
                if (limit > -1)
                {
                    sB.Append("limit=" + limit.ToString() + "&");
                }
                if (name != "")
                {
                    sB.Append("name=" + name + "&");
                }
                if (number != "")
                {
                    sB.Append("number=" + number + "&");
                }
                if (supplierName != "")
                {
                    sB.Append("supplier.name=" + supplierName + "&");
                }
                if (supplierGUID != "")
                {
                    sB.Append("supplier.guid=" + supplierGUID + "&");
                }
                string searchURL = m_URL_SupplierItems;
                if (sB.Length > 1)
                {
                    searchURL = searchURL + sB.ToString().Substring(0, sB.ToString().Length - 1);
                }
                m_jsonResp = ExecuteAPICall(searchURL, ReqVerb.GET, "");
                return JsonConvert.DeserializeObject<SearchResultsSupplierItem>(m_jsonResp);
            }
            catch (Exception ex)
            {
                m_errMsg = m_errMsg + ex.Message + ex.StackTrace;
                return null;
            }
        }

        /// <summary>
        /// Returns an array of ArenaClient.File objects associated with a Supplier Item's GUID
        /// </summary>
        /// <param name="supplierItemGUID"></param>
        /// <returns></returns>
        public ResultOfGetFileAssociations GetSupplierItemFileAssociations(string supplierItemGUID)
        {
            try
            {
                m_jsonResp = ExecuteAPICall(m_URL_SupplierItems + "/" + supplierItemGUID + "/files", ReqVerb.GET, "");
                return JsonConvert.DeserializeObject<ResultOfGetFileAssociations>(m_jsonResp);
            }
            catch (Exception ex)
            {
                m_errMsg = m_errMsg + ex.Message + ex.StackTrace;
                return null;
            }
        }
        
        /// <summary>
        /// Returns information on a single file associated with a Supplier Item
        /// </summary>
        /// <param name="supplierItemGUID"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public File GetSupplierItemFileInfo(string supplierItemGUID, string fileGUID)
        {
            try
            {
                m_jsonResp = ExecuteAPICall(m_URL_SupplierItems + "/" + supplierItemGUID + "/files/" + fileGUID, ReqVerb.GET, "");
                return JsonConvert.DeserializeObject<File>(m_jsonResp);
            }
            catch (Exception ex)
            {
                m_errMsg = m_errMsg + ex.Message + ex.StackTrace;
                return null;
            }
        }

        /// <summary>
        /// Downloads a file for an item with a given GUID
        /// </summary>
        /// <param name="itemGUID">GUID of the item or supplier item</param>
        /// <param name="fileGUID">GUID of the file ASSOCIATION to download (there appears to be some confusion (?) with the API-- 
        /// the API says to use the FILE GUID, but I get a 'invalid request' when I do that.  To download the file, I have to supply the GUID of the file's ASSOCIATION</param>
        /// <param name="outputPathAndFile">Location to save the downloaded file</param>
        /// <param name="isSupplierItem">Set FALSE to get file of an ITEM's GUID; leave true to get file of a SUPPLIER ITEM's GUID</param>
        /// <returns></returns>
        public Boolean DownloadFile(string itemGUID, string fileGUID, string outputPathAndFile, Boolean isSupplierItem=true)
        {
            try
            {
                //Delete the file, if it exists
                if (System.IO.File.Exists(outputPathAndFile))
                {
                    try
                    {
                        System.IO.File.Delete(outputPathAndFile);
                    } catch (Exception ex)
                    {
                        m_errMsg = outputPathAndFile + " already exists, but was unable to delete file." + ex.Message + ex.StackTrace;
                        return false;
                    }
                }
     
                string url = m_URL_Items + "/" + itemGUID + "/files/" + fileGUID + "/content";
                if (isSupplierItem)
                {
                    url = m_URL_SupplierItems + "/" + itemGUID + "/files/" + fileGUID + "/content";
                }
                WebClient req = new WebClient();
                req.Headers.Add("content_type:application/json");
                req.Headers.Add("arena_session_id:" + m_sessionID);
                req.DownloadFile(url, outputPathAndFile);
                if (System.IO.File.Exists(outputPathAndFile))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                m_errMsg = m_errMsg + ex.Message + ex.StackTrace;
                return false;
            }
        }

    }   //End Class
    
}   //End namespace
