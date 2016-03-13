namespace RepoNav
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControlMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageDb = new MetroFramework.Controls.MetroTabPage();
            this.metroComboBoxDatabase = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelDatabase = new MetroFramework.Controls.MetroLabel();
            this.metroButtonConnect = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxAuthenType = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelLogin = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAuthenType = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxServerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelServerName = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageSetting = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPageGenerate = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroTabControlMain.SuspendLayout();
            this.metroTabPageDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Green;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabControlMain
            // 
            this.metroTabControlMain.Controls.Add(this.metroTabPageDb);
            this.metroTabControlMain.Controls.Add(this.metroTabPageSetting);
            this.metroTabControlMain.Controls.Add(this.metroTabPageGenerate);
            this.metroTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControlMain.Location = new System.Drawing.Point(20, 60);
            this.metroTabControlMain.Name = "metroTabControlMain";
            this.metroTabControlMain.SelectedIndex = 0;
            this.metroTabControlMain.Size = new System.Drawing.Size(1012, 688);
            this.metroTabControlMain.TabIndex = 0;
            this.metroTabControlMain.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabPageDb
            // 
            this.metroTabPageDb.Controls.Add(this.metroComboBoxDatabase);
            this.metroTabPageDb.Controls.Add(this.metroLabelDatabase);
            this.metroTabPageDb.Controls.Add(this.metroButtonConnect);
            this.metroTabPageDb.Controls.Add(this.metroComboBoxAuthenType);
            this.metroTabPageDb.Controls.Add(this.metroTextBoxPassword);
            this.metroTabPageDb.Controls.Add(this.metroLabelPassword);
            this.metroTabPageDb.Controls.Add(this.metroTextBoxLogin);
            this.metroTabPageDb.Controls.Add(this.metroLabelLogin);
            this.metroTabPageDb.Controls.Add(this.metroLabelAuthenType);
            this.metroTabPageDb.Controls.Add(this.metroTextBoxServerName);
            this.metroTabPageDb.Controls.Add(this.metroLabelServerName);
            this.metroTabPageDb.HorizontalScrollbarBarColor = true;
            this.metroTabPageDb.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageDb.Name = "metroTabPageDb";
            this.metroTabPageDb.Size = new System.Drawing.Size(1004, 649);
            this.metroTabPageDb.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPageDb.TabIndex = 0;
            this.metroTabPageDb.Text = "Database";
            this.metroTabPageDb.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPageDb.VerticalScrollbarBarColor = true;
            // 
            // metroComboBoxDatabase
            // 
            this.metroComboBoxDatabase.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBoxDatabase.FormattingEnabled = true;
            this.metroComboBoxDatabase.ItemHeight = 19;
            this.metroComboBoxDatabase.Location = new System.Drawing.Point(162, 186);
            this.metroComboBoxDatabase.Name = "metroComboBoxDatabase";
            this.metroComboBoxDatabase.Size = new System.Drawing.Size(218, 25);
            this.metroComboBoxDatabase.TabIndex = 13;
            // 
            // metroLabelDatabase
            // 
            this.metroLabelDatabase.AutoSize = true;
            this.metroLabelDatabase.Location = new System.Drawing.Point(31, 189);
            this.metroLabelDatabase.Name = "metroLabelDatabase";
            this.metroLabelDatabase.Size = new System.Drawing.Size(63, 19);
            this.metroLabelDatabase.TabIndex = 12;
            this.metroLabelDatabase.Text = "Database";
            // 
            // metroButtonConnect
            // 
            this.metroButtonConnect.Location = new System.Drawing.Point(162, 227);
            this.metroButtonConnect.Name = "metroButtonConnect";
            this.metroButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.metroButtonConnect.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonConnect.TabIndex = 11;
            this.metroButtonConnect.Text = "Connect";
            this.metroButtonConnect.Click += new System.EventHandler(this.metroButtonConnect_Click);
            // 
            // metroComboBoxAuthenType
            // 
            this.metroComboBoxAuthenType.DisplayMember = "SQL Server  Authentication";
            this.metroComboBoxAuthenType.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBoxAuthenType.FormattingEnabled = true;
            this.metroComboBoxAuthenType.ItemHeight = 19;
            this.metroComboBoxAuthenType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server  Authentication"});
            this.metroComboBoxAuthenType.Location = new System.Drawing.Point(162, 61);
            this.metroComboBoxAuthenType.Name = "metroComboBoxAuthenType";
            this.metroComboBoxAuthenType.Size = new System.Drawing.Size(218, 25);
            this.metroComboBoxAuthenType.TabIndex = 10;
            this.metroComboBoxAuthenType.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxAuthenType_SelectedIndexChanged);
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Location = new System.Drawing.Point(162, 147);
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '●';
            this.metroTextBoxPassword.Size = new System.Drawing.Size(218, 23);
            this.metroTextBoxPassword.TabIndex = 9;
            this.metroTextBoxPassword.Text = "123qwe!@#";
            this.metroTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.Location = new System.Drawing.Point(31, 147);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(63, 19);
            this.metroLabelPassword.TabIndex = 8;
            this.metroLabelPassword.Text = "Password";
            // 
            // metroTextBoxLogin
            // 
            this.metroTextBoxLogin.Location = new System.Drawing.Point(162, 106);
            this.metroTextBoxLogin.Name = "metroTextBoxLogin";
            this.metroTextBoxLogin.Size = new System.Drawing.Size(218, 23);
            this.metroTextBoxLogin.TabIndex = 7;
            this.metroTextBoxLogin.Text = "sa";
            // 
            // metroLabelLogin
            // 
            this.metroLabelLogin.AutoSize = true;
            this.metroLabelLogin.Location = new System.Drawing.Point(31, 106);
            this.metroLabelLogin.Name = "metroLabelLogin";
            this.metroLabelLogin.Size = new System.Drawing.Size(41, 19);
            this.metroLabelLogin.TabIndex = 6;
            this.metroLabelLogin.Text = "Login";
            // 
            // metroLabelAuthenType
            // 
            this.metroLabelAuthenType.AutoSize = true;
            this.metroLabelAuthenType.Location = new System.Drawing.Point(31, 64);
            this.metroLabelAuthenType.Name = "metroLabelAuthenType";
            this.metroLabelAuthenType.Size = new System.Drawing.Size(92, 19);
            this.metroLabelAuthenType.TabIndex = 4;
            this.metroLabelAuthenType.Text = "Authentication";
            // 
            // metroTextBoxServerName
            // 
            this.metroTextBoxServerName.Location = new System.Drawing.Point(162, 24);
            this.metroTextBoxServerName.Name = "metroTextBoxServerName";
            this.metroTextBoxServerName.Size = new System.Drawing.Size(218, 23);
            this.metroTextBoxServerName.TabIndex = 3;
            this.metroTextBoxServerName.Text = "knodejs";
            // 
            // metroLabelServerName
            // 
            this.metroLabelServerName.AutoSize = true;
            this.metroLabelServerName.Location = new System.Drawing.Point(31, 24);
            this.metroLabelServerName.Name = "metroLabelServerName";
            this.metroLabelServerName.Size = new System.Drawing.Size(87, 19);
            this.metroLabelServerName.TabIndex = 2;
            this.metroLabelServerName.Text = "Server Name";
            // 
            // metroTabPageSetting
            // 
            this.metroTabPageSetting.HorizontalScrollbarBarColor = true;
            this.metroTabPageSetting.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageSetting.Name = "metroTabPageSetting";
            this.metroTabPageSetting.Size = new System.Drawing.Size(1004, 649);
            this.metroTabPageSetting.TabIndex = 1;
            this.metroTabPageSetting.Text = "Setting";
            this.metroTabPageSetting.VerticalScrollbarBarColor = true;
            // 
            // metroTabPageGenerate
            // 
            this.metroTabPageGenerate.HorizontalScrollbarBarColor = true;
            this.metroTabPageGenerate.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageGenerate.Name = "metroTabPageGenerate";
            this.metroTabPageGenerate.Size = new System.Drawing.Size(1004, 649);
            this.metroTabPageGenerate.TabIndex = 2;
            this.metroTabPageGenerate.Text = "Generate";
            this.metroTabPageGenerate.VerticalScrollbarBarColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 768);
            this.Controls.Add(this.metroTabControlMain);
            this.Name = "FrmMain";
            this.Text = "RepoNav";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroTabControlMain.ResumeLayout(false);
            this.metroTabPageDb.ResumeLayout(false);
            this.metroTabPageDb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControlMain;
        private MetroFramework.Controls.MetroTabPage metroTabPageDb;
        private MetroFramework.Controls.MetroTabPage metroTabPageSetting;
        private MetroFramework.Controls.MetroTabPage metroTabPageGenerate;
        private MetroFramework.Controls.MetroTextBox metroTextBoxServerName;
        private MetroFramework.Controls.MetroLabel metroLabelServerName;
        private MetroFramework.Controls.MetroComboBox metroComboBoxAuthenType;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLogin;
        private MetroFramework.Controls.MetroLabel metroLabelLogin;
        private MetroFramework.Controls.MetroLabel metroLabelAuthenType;
        private MetroFramework.Controls.MetroButton metroButtonConnect;
        private MetroFramework.Controls.MetroComboBox metroComboBoxDatabase;
        private MetroFramework.Controls.MetroLabel metroLabelDatabase;
    }
}