namespace ArenaDemo
{
    partial class Test1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkspaceTest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkspaceProd = new System.Windows.Forms.TextBox();
            this.btnLoginTest = new System.Windows.Forms.Button();
            this.btnLogInProd = new System.Windows.Forms.Button();
            this.txtSessionIDTest = new System.Windows.Forms.TextBox();
            this.txtSessionIDProd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.rdbProd = new System.Windows.Forms.RadioButton();
            this.rdbTest = new System.Windows.Forms.RadioButton();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.tbpExamples = new System.Windows.Forms.TabPage();
            this.txtSupplierItemSearchResult0GUID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFindSupplierItems = new System.Windows.Forms.Button();
            this.txtSupplierItemPN_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchResult0GUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindItems = new System.Windows.Forms.Button();
            this.txtItemPN_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDownloadSupplierItemAttachments = new System.Windows.Forms.Button();
            this.tbpSetup = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbpExamples.SuspendLayout();
            this.tbpSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(183, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(472, 38);
            this.txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LogIn Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(472, 38);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Workspace ID (Test)";
            // 
            // txtWorkspaceTest
            // 
            this.txtWorkspaceTest.Location = new System.Drawing.Point(306, 173);
            this.txtWorkspaceTest.Name = "txtWorkspaceTest";
            this.txtWorkspaceTest.Size = new System.Drawing.Size(472, 38);
            this.txtWorkspaceTest.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Workspace ID (Prod)";
            // 
            // txtWorkspaceProd
            // 
            this.txtWorkspaceProd.Location = new System.Drawing.Point(306, 234);
            this.txtWorkspaceProd.Name = "txtWorkspaceProd";
            this.txtWorkspaceProd.Size = new System.Drawing.Size(472, 38);
            this.txtWorkspaceProd.TabIndex = 6;
            // 
            // btnLoginTest
            // 
            this.btnLoginTest.Location = new System.Drawing.Point(801, 173);
            this.btnLoginTest.Name = "btnLoginTest";
            this.btnLoginTest.Size = new System.Drawing.Size(212, 48);
            this.btnLoginTest.TabIndex = 8;
            this.btnLoginTest.Text = "LogIn (Test)";
            this.btnLoginTest.UseVisualStyleBackColor = true;
            this.btnLoginTest.Click += new System.EventHandler(this.btnLoginTest_Click);
            // 
            // btnLogInProd
            // 
            this.btnLogInProd.Location = new System.Drawing.Point(801, 228);
            this.btnLogInProd.Name = "btnLogInProd";
            this.btnLogInProd.Size = new System.Drawing.Size(212, 48);
            this.btnLogInProd.TabIndex = 9;
            this.btnLogInProd.Text = "LogIn (Prod)";
            this.btnLogInProd.UseVisualStyleBackColor = true;
            this.btnLogInProd.Click += new System.EventHandler(this.btnLogInProd_Click);
            // 
            // txtSessionIDTest
            // 
            this.txtSessionIDTest.Location = new System.Drawing.Point(30, 63);
            this.txtSessionIDTest.Name = "txtSessionIDTest";
            this.txtSessionIDTest.Size = new System.Drawing.Size(834, 38);
            this.txtSessionIDTest.TabIndex = 11;
            // 
            // txtSessionIDProd
            // 
            this.txtSessionIDProd.Location = new System.Drawing.Point(30, 127);
            this.txtSessionIDProd.Name = "txtSessionIDProd";
            this.txtSessionIDProd.Size = new System.Drawing.Size(834, 38);
            this.txtSessionIDProd.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Controls.Add(this.rdbProd);
            this.groupBox1.Controls.Add(this.rdbTest);
            this.groupBox1.Controls.Add(this.txtSessionIDTest);
            this.groupBox1.Controls.Add(this.txtSessionIDProd);
            this.groupBox1.Location = new System.Drawing.Point(1028, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 257);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Most Recent Session ID";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(652, 190);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(212, 48);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.Location = new System.Drawing.Point(870, 122);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(33, 32);
            this.rdbProd.TabIndex = 14;
            this.rdbProd.TabStop = true;
            this.rdbProd.UseVisualStyleBackColor = true;
            this.rdbProd.CheckedChanged += new System.EventHandler(this.rdbProd_CheckedChanged);
            // 
            // rdbTest
            // 
            this.rdbTest.AutoSize = true;
            this.rdbTest.Location = new System.Drawing.Point(870, 63);
            this.rdbTest.Name = "rdbTest";
            this.rdbTest.Size = new System.Drawing.Size(33, 32);
            this.rdbTest.TabIndex = 13;
            this.rdbTest.TabStop = true;
            this.rdbTest.UseVisualStyleBackColor = true;
            this.rdbTest.CheckedChanged += new System.EventHandler(this.rdbTest_CheckedChanged);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tabPage1);
            this.tbc.Controls.Add(this.tbpExamples);
            this.tbc.Controls.Add(this.tbpSetup);
            this.tbc.Location = new System.Drawing.Point(12, 398);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(1942, 938);
            this.tbc.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtResponse);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1922, 880);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Response";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResponse.Location = new System.Drawing.Point(6, 6);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(1916, 649);
            this.txtResponse.TabIndex = 0;
            // 
            // tbpExamples
            // 
            this.tbpExamples.Controls.Add(this.btnDownloadSupplierItemAttachments);
            this.tbpExamples.Controls.Add(this.txtSupplierItemSearchResult0GUID);
            this.tbpExamples.Controls.Add(this.label8);
            this.tbpExamples.Controls.Add(this.btnFindSupplierItems);
            this.tbpExamples.Controls.Add(this.txtSupplierItemPN_Search);
            this.tbpExamples.Controls.Add(this.label7);
            this.tbpExamples.Controls.Add(this.txtSearchResult0GUID);
            this.tbpExamples.Controls.Add(this.label6);
            this.tbpExamples.Controls.Add(this.btnFindItems);
            this.tbpExamples.Controls.Add(this.txtItemPN_Search);
            this.tbpExamples.Controls.Add(this.label5);
            this.tbpExamples.Location = new System.Drawing.Point(10, 48);
            this.tbpExamples.Name = "tbpExamples";
            this.tbpExamples.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExamples.Size = new System.Drawing.Size(1922, 880);
            this.tbpExamples.TabIndex = 1;
            this.tbpExamples.Text = "Test Functions";
            this.tbpExamples.UseVisualStyleBackColor = true;
            // 
            // txtSupplierItemSearchResult0GUID
            // 
            this.txtSupplierItemSearchResult0GUID.Location = new System.Drawing.Point(1020, 219);
            this.txtSupplierItemSearchResult0GUID.Name = "txtSupplierItemSearchResult0GUID";
            this.txtSupplierItemSearchResult0GUID.Size = new System.Drawing.Size(520, 38);
            this.txtSupplierItemSearchResult0GUID.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(795, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Element 0 GUID";
            // 
            // btnFindSupplierItems
            // 
            this.btnFindSupplierItems.Location = new System.Drawing.Point(793, 148);
            this.btnFindSupplierItems.Name = "btnFindSupplierItems";
            this.btnFindSupplierItems.Size = new System.Drawing.Size(1095, 46);
            this.btnFindSupplierItems.TabIndex = 7;
            this.btnFindSupplierItems.Text = "Find Supplier Items (method SearchSupplierItem)";
            this.btnFindSupplierItems.UseVisualStyleBackColor = true;
            this.btnFindSupplierItems.Click += new System.EventHandler(this.btnFindSupplierItems_Click);
            // 
            // txtSupplierItemPN_Search
            // 
            this.txtSupplierItemPN_Search.Location = new System.Drawing.Point(299, 156);
            this.txtSupplierItemPN_Search.Name = "txtSupplierItemPN_Search";
            this.txtSupplierItemPN_Search.Size = new System.Drawing.Size(468, 38);
            this.txtSupplierItemPN_Search.TabIndex = 6;
            this.txtSupplierItemPN_Search.Text = "MX25R2035FM1IH0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Supplier Part Number";
            // 
            // txtSearchResult0GUID
            // 
            this.txtSearchResult0GUID.Location = new System.Drawing.Point(1020, 85);
            this.txtSearchResult0GUID.Name = "txtSearchResult0GUID";
            this.txtSearchResult0GUID.Size = new System.Drawing.Size(520, 38);
            this.txtSearchResult0GUID.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Element 0 GUID";
            // 
            // btnFindItems
            // 
            this.btnFindItems.Location = new System.Drawing.Point(793, 20);
            this.btnFindItems.Name = "btnFindItems";
            this.btnFindItems.Size = new System.Drawing.Size(1095, 46);
            this.btnFindItems.TabIndex = 2;
            this.btnFindItems.Text = "FindItems (method SearchItem)";
            this.btnFindItems.UseVisualStyleBackColor = true;
            this.btnFindItems.Click += new System.EventHandler(this.btnFindItems_Click);
            // 
            // txtItemPN_Search
            // 
            this.txtItemPN_Search.Location = new System.Drawing.Point(247, 14);
            this.txtItemPN_Search.Name = "txtItemPN_Search";
            this.txtItemPN_Search.Size = new System.Drawing.Size(520, 38);
            this.txtItemPN_Search.TabIndex = 1;
            this.txtItemPN_Search.Text = "700022-00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item Part Number";
            // 
            // btnDownloadSupplierItemAttachments
            // 
            this.btnDownloadSupplierItemAttachments.Location = new System.Drawing.Point(793, 275);
            this.btnDownloadSupplierItemAttachments.Name = "btnDownloadSupplierItemAttachments";
            this.btnDownloadSupplierItemAttachments.Size = new System.Drawing.Size(720, 46);
            this.btnDownloadSupplierItemAttachments.TabIndex = 10;
            this.btnDownloadSupplierItemAttachments.Text = "Download Supplier Item Attachments";
            this.btnDownloadSupplierItemAttachments.UseVisualStyleBackColor = true;
            this.btnDownloadSupplierItemAttachments.Click += new System.EventHandler(this.btnDownloadSupplierItemAttachments_Click);
            // 
            // tbpSetup
            // 
            this.tbpSetup.Controls.Add(this.txtOutputDir);
            this.tbpSetup.Controls.Add(this.label9);
            this.tbpSetup.Location = new System.Drawing.Point(10, 48);
            this.tbpSetup.Name = "tbpSetup";
            this.tbpSetup.Size = new System.Drawing.Size(1922, 880);
            this.tbpSetup.TabIndex = 2;
            this.tbpSetup.Text = "Set Up";
            this.tbpSetup.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(503, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Output Directory for Downloaded Files:";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(525, 22);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(1093, 38);
            this.txtOutputDir.TabIndex = 1;
            this.txtOutputDir.Text = "C:\\Temp\\";
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2084, 1301);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogInProd);
            this.Controls.Add(this.btnLoginTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWorkspaceProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWorkspaceTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Name = "Test1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test1_FormClosing);
            this.Load += new System.EventHandler(this.Test1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbpExamples.ResumeLayout(false);
            this.tbpExamples.PerformLayout();
            this.tbpSetup.ResumeLayout(false);
            this.tbpSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkspaceTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkspaceProd;
        private System.Windows.Forms.Button btnLoginTest;
        private System.Windows.Forms.Button btnLogInProd;
        private System.Windows.Forms.TextBox txtSessionIDTest;
        private System.Windows.Forms.TextBox txtSessionIDProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbProd;
        private System.Windows.Forms.RadioButton rdbTest;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TabPage tbpExamples;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFindItems;
        private System.Windows.Forms.TextBox txtItemPN_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchResult0GUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindSupplierItems;
        private System.Windows.Forms.TextBox txtSupplierItemPN_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSupplierItemSearchResult0GUID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDownloadSupplierItemAttachments;
        private System.Windows.Forms.TabPage tbpSetup;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Label label9;
    }
}

