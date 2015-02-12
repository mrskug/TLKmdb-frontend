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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public string login
        {
            get { return loginTextBox.Text; }
        }
        public string password
        {
            get { return passTextBox.Text; }
        }

        public string server
        {
            get { return serverTextBox.Text; }
        }

        private void settingsCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
