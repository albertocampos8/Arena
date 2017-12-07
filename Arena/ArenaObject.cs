using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena
{
    /// <summary>
    /// Used for Arena LogIns
    /// </summary>
    public class LogInCredential
    {
        private string m_email = "";
        private string m_password = "";
        private string m_workspaceId = "";

        public string email { get => m_email; set => m_email = value; }
        public string password { get => m_password; set => m_password = value; }
        public string workspaceId { get => m_workspaceId; set => m_workspaceId = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email">Email used to log in</param>
        /// <param name="password">Password associated with email login</param>
        /// <param name="workspaceID">Workspace ID to log in to; if blank, user is logged in to last workspace</param>
        public LogInCredential(string email, string password, string workspaceID)
        {
            m_email = email;
            m_password = password;
            m_workspaceId = workspaceID;
        }
    }
    
    public class Address
    {
        private string m_address1 = "";
        private string m_address2 = "";
        private string m_city = "";
        private string m_country = "";
        private string m_label = "";
        private string m_postalCode = "";
        private string m_province = "";
        private string m_state = "";

        public string address1 { get => m_address1; set => m_address1 = value; }
        public string address2 { get => m_address2; set => m_address2 = value; }
        public string city { get => m_city; set => m_city = value; }
        public string country { get => m_country; set => m_country = value; }
        public string label { get => m_label; set => m_label = value; }
        public string postalCode { get => m_postalCode; set => m_postalCode = value; }
        public string province { get => m_province; set => m_province = value; }
        public string state { get => m_state; set => m_state = value; }

        public Address()
        {

        }
    }

    public class User
    {
        private string m_email = "";
        private Boolean m_enabled = true;
        private string m_firstName = "";
        private string m_fullName = "";
        private string m_guid = "";
        private string m_lastName = "";
        private string m_type = "";

        /// <summary>
        /// User Email Address
        /// </summary>
        public string email { get => m_email; set => m_email = value; }

        /// <summary>
        /// Indicates whether user account is enabled in workspace
        /// </summary>
        public bool enabled { get => m_enabled; set => m_enabled = value; }

        /// <summary>
        /// User First Name
        /// </summary>
        public string firstName { get => m_firstName; set => m_firstName = value; }

        /// <summary>
        /// User Full Name
        /// </summary>
        public string fullName { get => m_fullName; set => m_fullName = value; }

        /// <summary>
        /// Unique identifier for user
        /// </summary>
        public string guid { get => m_guid; set => m_guid = value; }

        /// <summary>
        /// User Last Name
        /// </summary>
        public string lastName { get => m_lastName; set => m_lastName = value; }

        /// <summary>
        /// User Type (EMPLOYEE, PARTNER, BASIC_SUPPLIER, ADVANCED_SUPPLIER, INTEGRATION)
        /// </summary>
        public string type { get => m_type; set => m_type = value; }

        public User()
        {

        }
    }

    public class Category
    {
        private Boolean m_activated = true;
        private Boolean m_assignable = true;
        private string m_creationDateTime = "";
        private User m_creator = null;
        private string m_description = "";
        private string m_guid = "";
        private int m_level = -1;
        private string m_name = "";

        /// <summary>
        /// Indicates whether or not category is activated for use in workspace
        /// </summary>
        public bool activated { get => m_activated; set => m_activated = value; }
        /// <summary>
        /// Indicates whether or not an item can be assigned to the category
        /// </summary>
        public bool assignable { get => m_assignable; set => m_assignable = value; }
        /// <summary>
        /// Date and time Category was created
        /// </summary>
        public string creationDateTime { get => m_creationDateTime; set => m_creationDateTime = value; }
        /// <summary>
        /// Creator obect of the category
        /// </summary>
        public User creator { get => m_creator; set => m_creator = value; }
        /// <summary>
        /// Category description
        /// </summary>
        public string description { get => m_description; set => m_description = value; }
        /// <summary>
        /// Unique identifier for category
        /// </summary>
        public string guid { get => m_guid; set => m_guid = value; }
        /// <summary>
        /// Depth in the category tree at which a category appears
        /// </summary>
        public int level { get => m_level; set => m_level = value; }
        /// <summary>
        /// Name of the category
        /// </summary>
        public string name { get => m_name; set => m_name = value; }

        public Category()
        {

        }

        public Category(string guid)
        {
            m_guid = guid;
        }

        public Category(Boolean active,
            Boolean assignable,
            string dtTimeCreated,
            User c,
            string desc,
            string guid,
            int level,
            string name)
        {
            m_activated = active;
            m_assignable = assignable;
            m_creationDateTime = dtTimeCreated;
            m_creator = c;
            m_description = desc;
            m_guid = guid;
            m_level = level;
            m_name = name;
        }

 

    }

    public class File
    {
        private User m_author;
        private Category m_category;
        private string m_creationDateTime = "";
        private string m_description = "";
        private string m_edition = "";
        private string m_format = "";
        private string m_guid = "";
        private Boolean m_hasMarkUp = false;
        private string m_lastModifiedDateTime = "";
        private Boolean m_latest = false;
        private string m_location = "";
        private Boolean m_locked =false;
        private string m_mimeType = "";
        private string m_name = "";
        private string m_number = "";
        private Boolean m_private =false;
        private Int64 m_size = -1;
        private int m_storageMethod = -1;
        private string m_storageMethodName = "";
        private string m_title = "";

        public User author { get => m_author; set => m_author = value; }
        public Category category { get => m_category; set => m_category = value; }
        public string creationDateTime { get => m_creationDateTime; set => m_creationDateTime = value; }
        public string description { get => m_description; set => m_description = value; }
        public string edition { get => m_edition; set => m_edition = value; }
        public string format { get => m_format; set => m_format = value; }
        public string guid { get => m_guid; set => m_guid = value; }
        public bool hasMarkUp { get => m_hasMarkUp; set => m_hasMarkUp = value; }
        public string lastModifiedDateTime { get => m_lastModifiedDateTime; set => m_lastModifiedDateTime = value; }
        public bool latest { get => m_latest; set => m_latest = value; }
        public string location { get => m_location; set => m_location = value; }
        public bool locked { get => m_locked; set => m_locked = value; }
        public string mimeType { get => m_mimeType; set => m_mimeType = value; }
        public string name { get => m_name; set => m_name = value; }
        public string number { get => m_number; set => m_number = value; }
        public long size { get => m_size; set => m_size = value; }
        public string storageMethodName { get => m_storageMethodName; set => m_storageMethodName = value; }
        public string title { get => m_title; set => m_title = value; }
        public bool @private { get => m_private; set => m_private = value; }
        public int storageMethod { get => m_storageMethod; set => m_storageMethod = value; }

        public File()
        {

        }
}

    public class FileAssociation
    {
        private File m_file;
        private string m_guid = "";
        private Boolean m_primary;


        public File file { get => m_file; set => m_file = value; }
        public string guid { get => m_guid; set => m_guid = value; }
        public bool primary { get => m_primary; set => m_primary = value; }

        public FileAssociation()
        {

        }
    }

    public class ItemLifeCyclePhase
    {
        private Boolean m_active = true;
        private string m_guid = "";
        private string m_name = "";
        private string m_shortName = "";
        private string m_stage = "";
        private Boolean m_used = true;

        public bool active { get => m_active; set => m_active = value; }
        public string guid { get => m_guid; set => m_guid = value; }
        public string name { get => m_name; set => m_name = value; }
        public string shortName { get => m_shortName; set => m_shortName = value; }
        public string stage { get => m_stage; set => m_stage = value; }
        public bool used { get => m_used; set => m_used = value; }

        public ItemLifeCyclePhase()
        {

        }
    }

    public class CompactItem
    {
        private Category m_category = null;
        private string m_creationDateTime = "";
        private string m_guid = "";
        private ItemLifeCyclePhase m_lifecyclePhase = null;
        private string m_name = "";
        private string m_number = "";
        private string m_revisionNumber = "";

        /// <summary>
        /// Category of the item
        /// </summary>
        public Category category { get => m_category; set => m_category = value; }

        /// <summary>
        /// Date and time item was created
        /// </summary>
        public string creationDateTime { get => m_creationDateTime; set => m_creationDateTime = value; }

        /// <summary>
        /// Unique object identifier
        /// </summary>
        public string guid { get => m_guid; set => m_guid = value; }

        /// <summary>
        /// LifeCycle phase of the item
        /// </summary>
        public ItemLifeCyclePhase lifecyclePhase { get => m_lifecyclePhase; set => m_lifecyclePhase = value; }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string name { get => m_name; set => m_name = value; }

        /// <summary>
        /// Item Number
        /// </summary>
        public string number { get => m_number; set => m_number = value; }

        /// <summary>
        /// Revision of item
        /// </summary>
        public string revisionNumber { get => m_revisionNumber; set => m_revisionNumber = value; }

        public CompactItem()
        {

        }

        public CompactItem(Category c,
                           string dtTimeCreated,
                           string gid,
                           ItemLifeCyclePhase lifeCycle,
                           string name,
                           string number,
                           string revNumber)
        {
            m_category = c;
            m_creationDateTime = dtTimeCreated;
            m_guid = gid;
            m_name = name;
            m_number = number;
            m_revisionNumber = revNumber;
        }
    }

    public class SearchResultsItem
    {
        private int m_count = -1;
        private CompactItem[] m_results;

        /// <summary>
        /// Count of items in search result
        /// </summary>
        public int Count { get => m_count; set => m_count = value; }

        /// <summary>
        /// Array of Compact Items found by executing search
        /// </summary>
        public CompactItem[] Results { get => m_results; set => m_results = value; }
    }

    public class SearchResultsSupplierItem
    {
        private int m_count = -1;
        private SupplierItem[] m_results;

        /// <summary>
        /// Count of items in search result
        /// </summary>
        public int Count { get => m_count; set => m_count = value; }

        /// <summary>
        /// Array of Compact Items found by executing search
        /// </summary>
        public SupplierItem[] Results { get => m_results; set => m_results = value; }
    }

    public class ResultOfGetFileAssociations
    {
        private int m_count=-1;
        private FileAssociation[] m_results;

        public int count { get => m_count; set => m_count = value; }
        public FileAssociation[] results { get => m_results; set => m_results = value; }
        public ResultOfGetFileAssociations()
        {

        }
    }

    public class Supplier
    {
        private int m_accountNumber=-1;
        private Address[] m_addresses;
        private Boolean m_approvalStatus;
        private string m_creationDateTime = "";
        private User m_creator;
        private string m_description = "";
        private string m_guid = "";
        private string m_name = "";
        private string[] m_phoneNumbers;
        private string m_supplierID = "";
        private string m_website = "";

        public int accountNumber { get => m_accountNumber; set => m_accountNumber = value; }
        public Address[] addresses { get => m_addresses; set => m_addresses = value; }
        public bool approvalStatus { get => m_approvalStatus; set => m_approvalStatus = value; }
        public string creationDateTime { get => m_creationDateTime; set => m_creationDateTime = value; }
        public User creator { get => m_creator; set => m_creator = value; }
        public string description { get => m_description; set => m_description = value; }
        public string guid { get => m_guid; set => m_guid = value; }
        public string name { get => m_name; set => m_name = value; }
        public string[] phoneNumbers { get => m_phoneNumbers; set => m_phoneNumbers = value; }
        public string supplierID { get => m_supplierID; set => m_supplierID = value; }
        public string website { get => m_website; set => m_website = value; }

        public Supplier()
        {

        }
    }

    public class SupplierItem
    {
        private string m_creationDateTime = "";
        private string m_Description = "";
        private string m_guid = "";
        private string m_name = "";
        private string m_number = "";
        private Boolean m_offTheShelf = true;
        private Supplier m_supplier;
        private string m_type = "";
        private string m_uom = "";

        /// <summary>
        /// Creation date of Supplier Item
        /// </summary>
        public string creationDateTime { get => m_creationDateTime; set => m_creationDateTime = value; }

        /// <summary>
        /// Supplier Item Description
        /// </summary>
        public string Description { get => m_Description; set => m_Description = value; }

        /// <summary>
        /// Unique ID of supplier item
        /// </summary>
        public string guid { get => m_guid; set => m_guid = value; }

        /// <summary>
        /// Supplier Item Name
        /// </summary>
        public string name { get => m_name; set => m_name = value; }

        /// <summary>
        /// Supplier Item Number
        /// </summary>
        public string number { get => m_number; set => m_number = value; }

        /// <summary>
        /// TRUE if this is an off-the-shelf part number
        /// </summary>
        public bool offTheShelf { get => m_offTheShelf; set => m_offTheShelf = value; }

        /// <summary>
        /// Supplier Object
        /// </summary>
        public Supplier supplier { get => m_supplier; set => m_supplier = value; }

        /// <summary>
        /// Type of supplier item (PART, PROCESS, DOCUMENT)
        /// </summary>
        public string type { get => m_type; set => m_type = value; }

        /// <summary>
        /// Supplier Item Unit of Measure
        /// </summary>
        public string uom { get => m_uom; set => m_uom = value; }

        public SupplierItem()
        {

        }
    }
}
