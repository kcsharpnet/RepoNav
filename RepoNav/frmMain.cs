using System;
using DatabaseSchemaReader;
using MetroFramework.Forms;

namespace RepoNav
{
    public partial class FrmMain : MetroForm
    {
        private const string providername = "System.Data.SqlClient";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitialControlState();
        }

        private void InitialControlState()
        {
            metroComboBoxAuthenType.SelectedIndex = 1;
        }

        private void metroComboBoxAuthenType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLoginDetail(metroComboBoxAuthenType.SelectedIndex == 1);
        }

        private void SetLoginDetail(bool isEnable)
        {
            metroTextBoxLogin.Enabled = isEnable;
            metroTextBoxPassword.Enabled = isEnable;
            if (isEnable) return;
            metroTextBoxLogin.Text = "";
            metroTextBoxPassword.Text = "";
        }

        private void metroButtonConnect_Click(object sender, EventArgs e)
        {
            string connectionString;
            var windows = "Data Source={0};Intergrate Security=true;initial catalog={1};";
            var sqlServer = "Data Source={0};user id={1};password={2};initial catalog={3};";
            if (metroComboBoxAuthenType.SelectedIndex == 1)
                connectionString = string.Format(sqlServer, metroTextBoxServerName.Text, metroTextBoxLogin.Text,
                    metroTextBoxPassword.Text, "Podium1");
            else
                connectionString = string.Format(windows, metroTextBoxServerName.Text, "Podium1");

            var dbReader = new DatabaseReader(connectionString, providername);
            var tables = dbReader.AllTables();

        }
    }
}