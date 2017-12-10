using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace SimpleMySQLBackup
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            string connstring;

            if (ServerTextBox.Text == string.Empty || DatabaseTextBox.Text == string.Empty || UserIdTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please check server, database or user id fields!");
            }
            else
            {
                connstring = "server=" + (ServerTextBox.Text) + ";" + "port=" + (ServerPortTextBox.Text) + ";" + "database=" + (DatabaseTextBox.Text) + ";" + "uid=" + (UserIdTextBox.Text) + ";" + "password=" + (PasswdTextBox.Text) + ";";
                try
                {
                    conn = new MySqlConnection();
                    conn.ConnectionString = connstring;
                    conn.Open();
                    MessageBox.Show("Connection Success!");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private void ServerPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char port = e.KeyChar;

            if (!Char.IsDigit(port) && port != Convert.ToChar(Keys.Back) && port != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void BtnBckpBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL File |*.sql";

            if(sfd.ShowDialog () == DialogResult.OK)
            {
                string savePath = Path.GetFullPath(sfd.FileName);
                SavePathBox.Text = savePath;
                BtnBackp.Enabled = true;
            }
        }

        private void BtnBackp_Click(object sender, EventArgs e)
        {          
            string connString;
            string file = (SavePathBox.Text);
            
            if (string.IsNullOrEmpty(this.ServerTextBox.Text) || string.IsNullOrEmpty(this.ServerPortTextBox.Text) || string.IsNullOrEmpty(this.DatabaseTextBox.Text) || string.IsNullOrEmpty(this.UserIdTextBox.Text))
            {
                 MessageBox.Show("Please check fields in details section.");
            }
            else if (string.IsNullOrEmpty(this.BckpCharSetBox.Text))
            {
                MessageBox.Show("Please choose the charset for backup");
            }
            else if (ConvertDateTimeCheckBox.Checked != true)
            {
                MessageBox.Show("Please check convert zero date time");
            }
            else
            {
                connString = "server=" + (ServerTextBox.Text) + ";" + "port=" + (ServerPortTextBox.Text) + ";" + "database=" + (DatabaseTextBox.Text) + ";" + "uid=" + (UserIdTextBox.Text) + ";" + "password=" + (PasswdTextBox.Text) + ";" + "charset=" + (BckpCharSetBox.Text) + ";" + "convertzerodatetime=true;";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportToFile(file);
                                conn.Close();
                                MessageBox.Show("Backup Complete!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
        }

        private void BtnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL File |*.sql";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string opnPath = Path.GetFullPath(ofd.FileName);
                RestorePathBox.Text = (opnPath);
                //BtnRestor.Enabled = true;
            }
        }

        private void BtnRestor_Click(object sender, EventArgs e)
        {
            string connString;
            string file = (RestorePathBox.Text);

            if (string.IsNullOrEmpty(this.ServerTextBox.Text) || string.IsNullOrEmpty(this.ServerPortTextBox.Text) || string.IsNullOrEmpty(this.DatabaseTextBox.Text) || string.IsNullOrEmpty(this.UserIdTextBox.Text))
            {
                MessageBox.Show("Please check fields in details section.");
            }            
            else if (string.IsNullOrEmpty(this.RestorCharSetBox.Text))
            {
                MessageBox.Show("Please choose the charset for restore");
            }
            else if (RestorConvertDateTimeCheckBox.Checked != true)
            {
                MessageBox.Show("Please check convert zero date time");
            }
            else
            {
                connString = "server=" + (ServerTextBox.Text) + ";" + "port=" + (ServerPortTextBox.Text) + ";" + "database=" + (DatabaseTextBox.Text) + ";" + "uid=" + (UserIdTextBox.Text) + ";" + "password=" + (PasswdTextBox.Text) + ";" + "charset=" + (RestorCharSetBox.Text) + ";" + "convertzerodatetime=true;";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportFromFile(file);
                                conn.Close();
                                MessageBox.Show("Restore Complete!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnCr_Click(object sender, EventArgs e)
        {
            string connString;
            string file = (RestorePathBox.Text);

            if (string.IsNullOrEmpty(this.ServerTextBox.Text) || string.IsNullOrEmpty(this.ServerPortTextBox.Text) || string.IsNullOrEmpty(this.DatabaseTextBox.Text) || string.IsNullOrEmpty(this.UserIdTextBox.Text))
            {
                MessageBox.Show("Please check fields in details section.");
            }
            else if (string.IsNullOrEmpty(this.RestorNewCharSetBox.Text))
            {
                MessageBox.Show("Please choose the charset for restore");
            }
            else if (string.IsNullOrEmpty(this.RstorDatabaseNameBox.Text))
            {
                MessageBox.Show("Please type new database name to restore");
            }
            else
            {
                connString = "server=" + (ServerTextBox.Text) + ";" + "port=" + (ServerPortTextBox.Text) + ";" + "database=" + (DatabaseTextBox.Text) + ";" + "uid=" + (UserIdTextBox.Text) + ";" + "password=" + (PasswdTextBox.Text) + ";" + "charset=" + (RestorNewCharSetBox.Text) + ";" + "convertzerodatetime=true;";
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportInfo.TargetDatabase = (RstorDatabaseNameBox.Text);
                                mb.ImportInfo.DatabaseDefaultCharSet = (RestorNewCharSetBox.Text);
                                mb.ImportFromFile(file);
                                conn.Close();
                                MessageBox.Show("Restore Complete!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                BtnCr.Enabled = true;
                BtnRestor.Enabled = false;
            }
            else
            {
                BtnCr.Enabled = false;
                BtnRestor.Enabled = true;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://dev.mysql.com/doc/connector-net/en/connector-net-connection-options.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://dev.mysql.com/doc/connector-net/en/connector-net-connection-options.html");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitDialog = MessageBox.Show("Do you really want to close the program ?", "Exit", MessageBoxButtons.YesNo);
            if (exitDialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (exitDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
