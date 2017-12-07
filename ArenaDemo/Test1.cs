using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Arena;

namespace ArenaDemo
{
    public partial class Test1 : Form
    {
        private ArenaClient m_aTest;
        private ArenaClient m_aProd;
        private ArenaClient m_a;
        public Test1()
        {
            InitializeComponent();
        }


        private void Test1_Load(object sender, EventArgs e)
        {
            //Read email, password, workSpaceID from file, which is expected to be in the same folder as the exe
            string dir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            using (StreamReader sR = new StreamReader(dir + "\\LoginInfo.txt"))
            {
                //Line 1: login ID

                txtEmail.Text = sR.ReadLine();
                txtPassword.Text = sR.ReadLine();
                txtWorkspaceTest.Text = sR.ReadLine();
                txtWorkspaceProd.Text = sR.ReadLine();
            }

        }

        private void btnLoginTest_Click(object sender, EventArgs e)
        {
            try
            {
               
                m_aTest = new ArenaClient(txtEmail.Text, txtPassword.Text, txtWorkspaceTest.Text);
                txtResponse.Text = m_aTest.Login();
                txtSessionIDTest.Text = m_aTest.SessionID;
                rdbTest.Checked = true;
                rdbTest_CheckedChanged(null, null);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

           
        }

        private void btnLogInProd_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                m_aProd = new ArenaClient(txtEmail.Text, txtPassword.Text, txtWorkspaceProd.Text);
                txtResponse.Text = m_aProd.Login();
                txtSessionIDProd.Text = m_aProd.SessionID;
                rdbProd_CheckedChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void rdbTest_CheckedChanged(object sender, EventArgs e)
        {
            m_a = m_aTest;
        }

        private void rdbProd_CheckedChanged(object sender, EventArgs e)
        {
            m_a = m_aProd;
        }

        private void Test1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                m_aTest.Logout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            try
            {
                m_aProd.Logout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbTest.Checked)
                {
                    if (m_aTest.Logout())
                    {
                        MessageBox.Show("Logout successful.");
                    } else
                    {
                        MessageBox.Show("Logout failed: " + m_aTest.ErrMsg);
                    }
                    
                } else
                {
                    if (m_aProd.Logout())
                    {
                        MessageBox.Show("Logout successful.");
                    } else
                    {
                        MessageBox.Show("Logout failed: " + m_aProd.ErrMsg);
                    }
                    m_aProd.Logout();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnFindItems_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearchResult0GUID.Text = "";
                SearchResultsItem iSR = m_a.SearchItem(number: txtItemPN_Search.Text);
                if (iSR.Count>0)
                {
                    txtSearchResult0GUID.Text = iSR.Results[0].guid;
                }
                txtResponse.Text = m_a.JsonResp;
                tbc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(m_a.ErrMsg + ex.Message + ex.StackTrace);
            }

        }

        private void btnFindSupplierItems_Click(object sender, EventArgs e)
        {
            try
            {
                txtSupplierItemSearchResult0GUID.Text = "";
                SearchResultsSupplierItem iSR = m_a.SearchSupplierItem(number: txtSupplierItemPN_Search.Text);
                if (iSR.Count>0) {
                    txtSupplierItemSearchResult0GUID.Text = iSR.Results[0].guid;
                }
                
                txtResponse.Text = m_a.JsonResp;
                tbc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(m_a.ErrMsg + ex.Message + ex.StackTrace);
            }
        }

        private void btnDownloadSupplierItemAttachments_Click(object sender, EventArgs e)
        {
            try
            {
                txtResponse.Text = "";
                int nDownloaded = 0;
                ResultOfGetFileAssociations rogfa = m_a.GetSupplierItemFileAssociations(txtSupplierItemSearchResult0GUID.Text);
                for (int i= 0; i<rogfa.count;i++)
                {
                    string outPath =  txtOutputDir.Text + rogfa.results[i].file.name;
                    if (txtOutputDir.Text == outPath)
                    {
                        outPath = outPath + "test";
                    }
                    if (m_a.DownloadFile(txtSupplierItemSearchResult0GUID.Text, rogfa.results[i].guid, outPath))
                    {
                        nDownloaded++;
                    } else
                    {
                        txtResponse.Text = txtResponse.Text + m_a.ErrMsg;

                    }
                }
                MessageBox.Show(nDownloaded.ToString() + " files downloaded.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(m_a.ErrMsg + ex.Message + ex.StackTrace);
            }
        }
    }
}
