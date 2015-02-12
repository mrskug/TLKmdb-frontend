using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLKmdb_frontend
{
    public partial class MainWindow : Form
    {
        private readonly SettingsForm settingsForm;
        public MainWindow()
        {
            this.settingsForm = new SettingsForm();
            InitializeComponent();
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (settingsForm.server == "" || settingsForm.login == "" || settingsForm.password == "")
            {
                settingsForm.Show();
            }
            else
            {
                string user = settingsForm.login;
                string pass = settingsForm.password;
                string baseURL = settingsForm.server;
                string requestJson = "{ }";
                string type = "GET";
                consoleBox.AppendText(user + "\n" + pass + "\n" + baseURL + "\n");
                Request responseJson = new Request(baseURL, user, pass, requestJson, type);
                consoleBox.AppendText(responseJson.response);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
        }
    }
}
