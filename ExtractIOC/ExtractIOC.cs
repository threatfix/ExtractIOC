using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ExtractIOC
{
    public partial class ExtractIOC : Form
    {
        string whiteListLocation, exportLocation;
        List<string> ipv4List = new List<String>();
        List<string> iocList = new List<String>();
        List<string> md5List = new List<String>();
        List<string> emailList = new List<String>();
        List<string> domainList = new List<String>();
        int hashCt, ipCt, emailCt, domainCt;
        int uHashCt, uIpCt, uEmailCt, uDomainCt;

        public ExtractIOC()
        {
            InitializeComponent();
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            iocCountListBox.Items.Clear();
            string txtLine, wLine;
            int hitCount=0;
            hashCt = 0;
            ipCt = 0;
            emailCt = 0;
            domainCt = 0;

            uHashCt = 0;
            uIpCt = 0;
            uEmailCt = 0;
            uDomainCt = 0;

            StringBuilder txtFile = new StringBuilder();
            StringBuilder wList = new StringBuilder();

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text file|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                exportLocation = save_dialog.FileName.ToString();
            }
            // Read the file and display it line by line. 
            foreach (string fname in fileListingListBox.Items)
            {
                using (System.IO.StreamReader txtFileReader = new System.IO.StreamReader(fname))
                {
                    while ((txtLine = txtFileReader.ReadLine()) != null)
                    {
                        var ip4Add = Regex.Match(txtLine, @"^(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})$");
                        var hashAdd = Regex.Match(txtLine, @"^[0-9a-f]{32}$");
                        var emailAdd = Regex.Match(txtLine, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                        var domainAdd = Regex.Match(txtLine, @"^((?!-))(xn--)?[a-z0-9][a-z0-9-_]{0,61}[a-z0-9]{0,1}\.(xn--)?([a-z0-9\-]{1,61}|[a-z0-9-]{1,30}\.[a-z]{2,})$");

                        if (ip4Add.Success && ipv4CheckBox.Checked == true || hashAdd.Success && md5CheckBox.Checked == true || emailAdd.Success && emailCheckBox.Checked == true || domainAdd.Success && domainCheckBox.Checked == true)
                        {
                            if (whiteListLocation != null)
                            {
                                using (System.IO.StreamReader wListReader = new System.IO.StreamReader(whiteListLocation))
                                {
                                    hitCount = 0;
                                    while ((wLine = wListReader.ReadLine()) != null)
                                    {
                                        if (wLine.ToString() == txtLine.ToString())
                                        {
                                            hitCount++;
                                        }
                                    }
                                }
                            }
                            if (hitCount < 1)
                            {
                                if (safeIOCBox.Checked == true) txtLine = Regex.Replace(txtLine, @"\.", @"[.]");

                                if (ip4Add.Success && ipv4CheckBox.Checked == true) ipCt++;
                                else if (hashAdd.Success && md5CheckBox.Checked) hashCt++;
                                else if (emailAdd.Success && emailCheckBox.Checked == true) emailCt++;
                                else if (domainAdd.Success && domainCheckBox.Checked) domainCt++;

                                if (iocList.Contains(txtLine)) continue;
                                iocList.Add(txtLine);
                                if (ip4Add.Success && ipv4CheckBox.Checked == true)
                                {
                                    uIpCt++;
                                    ipv4List.Add(txtLine);
                                }
                                else if (hashAdd.Success && md5CheckBox.Checked)
                                {
                                    uHashCt++;
                                    md5List.Add(txtLine);
                                }
                                else if (emailAdd.Success && emailCheckBox.Checked == true)
                                {
                                    uEmailCt++;
                                    emailList.Add(txtLine);
                                }
                                else if (domainAdd.Success && domainCheckBox.Checked)
                                {
                                    uDomainCt++;
                                    domainList.Add(txtLine);
                                }
                                hitCount = 0;
                            }
                        }
                    }
                }
            }
            File.Delete(exportLocation);
            if (newLineRadio.Checked == true) saveAsList();
            if (csvRadio.Checked == true) saveAsCSV();
            iocCountListBox.Items.Add("Total IOCs Found");
            iocCountListBox.Items.Add("------------------------------------");
            if (ipv4CheckBox.Checked == true) iocCountListBox.Items.Add("IP Addresses:\t" + ipCt + " (" + uIpCt + " Unique)" );
            if (emailCheckBox.Checked == true) iocCountListBox.Items.Add("Email Addresses:\t" + emailCt + " (" + uEmailCt + " Unique)");
            if (md5CheckBox.Checked == true) iocCountListBox.Items.Add("MD5 Hashes:\t" + hashCt + " (" + uHashCt + " Unique)");
            if (domainCheckBox.Checked == true) iocCountListBox.Items.Add("Domains:\t\t" + domainCt + " (" + uDomainCt + " Unique)");
        }

        private void saveAsCSV()
        {
            if (ipv4CheckBox.Checked == true)
            {
                string ipv4CSV = String.Join(",", ipv4List);
                File.AppendAllText(exportLocation + "_IPv4.csv", ipv4CSV);
            }
            if (emailCheckBox.Checked == true)
            {
                string emailCSV = String.Join(",", emailList);
                File.AppendAllText(exportLocation + "_Email.csv", emailCSV);
            }
            if (md5CheckBox.Checked == true)
            {
                string md5CSV = String.Join(",", md5List);
                File.AppendAllText(exportLocation + "_MD5.csv", md5CSV);
            }
            if (domainCheckBox.Checked == true)
            {
                string domainCSV = String.Join(",", domainList);
                File.AppendAllText(exportLocation + "_Domain.csv", domainCSV);
            }
        }

        private void saveAsList()
        {
            if (ipv4CheckBox.Checked == true)
            {
                File.AppendAllText(exportLocation, "\r\nIP Addresses\r\n---------------------\n\r\n");
                File.AppendAllLines(exportLocation, ipv4List);
            }
            if (md5CheckBox.Checked == true)
            {
                File.AppendAllText(exportLocation, "\r\nMD5 Hashes\r\n---------------------\n\r\n");
                File.AppendAllLines(exportLocation, md5List);
            }
            if (emailCheckBox.Checked == true)
            {
                File.AppendAllText(exportLocation, "\r\nEmail Addresses\r\n---------------------\n\r\n");
                File.AppendAllLines(exportLocation, emailList);
            }
            if (domainCheckBox.Checked == true)
            {
                File.AppendAllText(exportLocation, "\r\nDomains\r\n---------------------\n\r\n");
                File.AppendAllLines(exportLocation, domainList);
            }
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            fileListingListBox.Items.Clear();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
            open_dialog.Multiselect = true;
            open_dialog.Title = "Select your IOC Files.";

            DialogResult dr = open_dialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in open_dialog.FileNames)
                {
                    // Create a PictureBox.
                    try
                    {
                        if (fileListingListBox.Items.Contains(file)) continue;
                        fileListingListBox.Items.Add(file);
                        extractButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                }
            }
        }

        private void modifyWListBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", whiteListLocation);
        }

        private void loadWListBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Whitelist File (*.wlf)|*.WLF";
            open_dialog.Title = "Select Your Whitelist.";

            DialogResult dr = open_dialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                whiteListLocation = open_dialog.FileName;
                modifyWListBtn.Enabled = true;

            }
        }

        private void threatBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.threatfix.com");
        }

        private void tFixLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.threatfix.com");
        }
    }
}
