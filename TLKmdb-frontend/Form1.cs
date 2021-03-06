﻿using System;
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
        private void fetchDatabase()
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
                consoleBox.AppendText(user + "\n" + pass + "\n" + baseURL + "\n" + "\n");

                Database TLK = new Database(baseURL, user, pass, "TLK");
                consoleBox.AppendText(TLK.populateDB());

                dataGridView.DataSource = TLK.persons;

                /**
                                foreach (Person person in TLK.persons)
                                {
                                    consoleBox.AppendText(person.pk.ToString() + "\n");
                                    consoleBox.AppendText(person.firstname.ToString() + "\n");
                                    consoleBox.AppendText(person.middlenames.ToString() + "\n");
                                    consoleBox.AppendText(person.lastname.ToString() + "\n");
                                    foreach (var item in person.member)
                                    {
                                        consoleBox.AppendText(item.pk.ToString() + "\n");
                                        consoleBox.AppendText(item.person.ToString() + "\n");
                                        consoleBox.AppendText(item.year.ToString() + "\n");
                                        consoleBox.AppendText(item.type.ToString() + "\n");
                                    }
                                }**/
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aboutWindow.show();
        }

        private void debugGetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchDatabase();
        }
    }
}
