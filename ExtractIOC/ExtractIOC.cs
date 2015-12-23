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
using System.Threading;
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
        int hashCt, ipCt, emailCt, domainCt, totalIOCct;
        int uHashCt, uIpCt, uEmailCt, uDomainCt, uIOCct;
        int lineCount;
        long currentLine;

        //Initialization
        //Initializes Form and Sets Default Values
        public ExtractIOC()
        {
            InitializeComponent();
            setProgressBarValues();
        }

        //Extraction - Main Extract
        //Handles Main Extraction Function. Compares Selected IOC Regex with Each Line - Places Matches in IOC Specific Bucket
        private void extractButton_Click(object sender, EventArgs e)
        {
            StringBuilder txtFile = new StringBuilder();
            StringBuilder wList = new StringBuilder();
            string txtLine, wLine, iocMatch;
            iocMatch = "";
            int hitCount = 0;
            hashCt = 0;
            ipCt = 0;
            emailCt = 0;
            domainCt = 0;
            uHashCt = 0;
            uIpCt = 0;
            uEmailCt = 0;
            uDomainCt = 0;
            totalIOCct = 0;
            uIOCct = 0;

            iocCountListBox.Items.Clear();

            extractSaveDialog();
            countLines();

            if (exportLocation != "")
            {
                // Read the file and display it line by line. 
                foreach (string fname in fileListingListBox.Items)
                {
                    currentLine = 0;

                    using (System.IO.StreamReader txtFileReader = new System.IO.StreamReader(fname))
                    {
                        while ((txtLine = txtFileReader.ReadLine()) != null)
                        {
                            UpdateProgressBar(1);

                            var ip4Add = Regex.Match(txtLine, @"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})");
                            var hashAdd = Regex.Match(txtLine, @"(^)?[^\w\d][0-9a-f]{32}[^\w\d]");
                            var emailAdd = Regex.Match(txtLine, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                            var domainAdd = Regex.Match(txtLine, @"((?!-))(xn--)?[a-z0-9][a-z0-9-_]{0,61}[a-z0-9]{0,1}\.(xn--)?([a-z0-9\-]{1,61}|[a-z0-9-]{1,30}\.[a-z]{2,})");
                            if (ip4Add.Success && ipv4CheckBox.Checked == true) iocMatch = ip4Add.Value;
                            else if (hashAdd.Success && md5CheckBox.Checked == true) iocMatch = hashAdd.Value;
                            else if (emailAdd.Success && emailCheckBox.Checked == true) iocMatch = emailAdd.Value;
                            else if (domainAdd.Success && domainCheckBox.Checked == true) iocMatch = domainAdd.Value;

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
                                    if (ip4Add.Success && ipv4CheckBox.Checked == true)
                                    {
                                        ipCt++;
                                        totalIOCct++;
                                    }
                                    else if (hashAdd.Success && md5CheckBox.Checked) 
                                    {
                                        hashCt++;
                                        totalIOCct++;
                                    }
                                    else if (emailAdd.Success && emailCheckBox.Checked == true)
                                    {
                                        emailCt++;
                                        totalIOCct++;
                                    }
                                    else if (domainAdd.Success && domainCheckBox.Checked) 
                                    {
                                        domainCt++;
                                        totalIOCct++;
                                    }

                                    if (iocList.Contains(iocMatch)) continue;
                                    iocList.Add(iocMatch);
                                    if (ip4Add.Success && ipv4CheckBox.Checked == true)
                                    {
                                        uIpCt++;
                                        uIOCct++;
                                        ipv4List.Add(iocMatch);
                                    }
                                    else if (hashAdd.Success && md5CheckBox.Checked)
                                    {
                                        uHashCt++;
                                        uIOCct++;
                                        md5List.Add(iocMatch);
                                    }
                                    else if (emailAdd.Success && emailCheckBox.Checked == true)
                                    {
                                        uEmailCt++;
                                        uIOCct++;
                                        emailList.Add(iocMatch);
                                    }
                                    else if (domainAdd.Success && domainCheckBox.Checked)
                                    {
                                        uDomainCt++;
                                        uIOCct++;
                                        domainList.Add(iocMatch);
                                    }
                                    hitCount = 0;
                                }
                            }
                        }
                    }
                }
                File.Delete(exportLocation);
                selectExportType();
                ShowIOCCounts();
                extractProgressBar.Value = 0;
                currentLine = 0;
                MessageBox.Show("Extraction Completed", "ExtractIOC");

                if (safeIOCBox.Checked == true) addSafeMode();
            }
        }

        //Initialization
        //Sets Minimum and Maximum Progress Bar Values
        private void setProgressBarValues()
        {
            extractProgressBar.Minimum = 0;
            extractProgressBar.Maximum = 100;
        }

        //Extraction - Save Dialog
        //Prompts User For Save Location
        private void extractSaveDialog()
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text file|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                exportLocation = save_dialog.FileName.ToString();
            }
            else
            {
                exportLocation = "";
            }

        }

        //Extraction - Safe Mode
        //Adds delimiters like [.] to values
        private void addSafeMode()
        {
            if (newLineRadio.Checked == true)
            {
                string unsafeText = File.ReadAllText(exportLocation);
                unsafeText = Regex.Replace(unsafeText, @"\.", @"[.]");
                File.WriteAllText(exportLocation, unsafeText);
            }

            if (csvRadio.Checked == true)
            {
                if (ipv4CheckBox.Checked == true)
                {
                    string unsafe_ipv4CSV = File.ReadAllText(exportLocation + "_IPv4.csv");
                    unsafe_ipv4CSV = Regex.Replace(unsafe_ipv4CSV, @"\.", @"[.]");
                    File.WriteAllText(exportLocation + "_IPv4.csv", unsafe_ipv4CSV);
                }
                if (emailCheckBox.Checked == true)
                {
                    string unsafe_emailCSV = File.ReadAllText(exportLocation + "_Email.csv");
                    unsafe_emailCSV = Regex.Replace(unsafe_emailCSV, @"\.", @"[.]");
                    File.WriteAllText(exportLocation + "_Email.csv", unsafe_emailCSV);
                }
                if (md5CheckBox.Checked == true)
                {
                    string unsafe_md5CSV = File.ReadAllText(exportLocation + "_MD5.csv");
                    unsafe_md5CSV = Regex.Replace(unsafe_md5CSV, @"\.", @"[.]");
                    File.WriteAllText(exportLocation + "_MD5.csv", unsafe_md5CSV);
                }
                if (domainCheckBox.Checked == true)
                {
                    string unsafe_domainCSV = File.ReadAllText(exportLocation + "_Domain.csv");
                    unsafe_domainCSV = Regex.Replace(unsafe_domainCSV, @"\.", @"[.]");
                    File.WriteAllText(exportLocation + "_Domain.csv", unsafe_domainCSV);
                }
            }
        }

        //Extraction - Export Type
        //Calls User Specified Export Function
        private void selectExportType()
        {
            if (newLineRadio.Checked == true) saveAsList();
            if (csvRadio.Checked == true) saveAsCSV();
        }

        //Extraction - IOC Counts
        //Displays IOC Counts in iocCountListBox
        private void ShowIOCCounts()
        {
            iocCountListBox.Items.Add("Total IOCs Found:\t" + totalIOCct + " (" + uIOCct + " Unique)");
            iocCountListBox.Items.Add("----------------------------------------------------------");
            if (ipv4CheckBox.Checked == true) iocCountListBox.Items.Add("IP Addresses:\t" + ipCt + " (" + uIpCt + " Unique)");
            if (emailCheckBox.Checked == true) iocCountListBox.Items.Add("Email Addresses:\t" + emailCt + " (" + uEmailCt + " Unique)");
            if (md5CheckBox.Checked == true) iocCountListBox.Items.Add("MD5 Hashes:\t" + hashCt + " (" + uHashCt + " Unique)");
            if (domainCheckBox.Checked == true) iocCountListBox.Items.Add("Domains:\t\t" + domainCt + " (" + uDomainCt + " Unique)");
        }

        //Extraction - CSV Generation
        //Creates CSV Files Based on IOC Buckets
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

        //Extraction - FullList Generation
        //Merges bucketed lists (IP List, MD5 List, etc) into main list
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

        //User Selection - IOC
        //Prompts user to select IOC Files
        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            fileListingListBox.Items.Clear();
            extractProgressBar.Value = 0;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
            open_dialog.Multiselect = true;
            open_dialog.Title = "Select your IOC Files.";

            DialogResult dr = open_dialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in open_dialog.FileNames)
                {
                    try
                    {
                        if (fileListingListBox.Items.Contains(file)) continue;
                        fileListingListBox.Items.Add(file);
                        extractButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong...contact me pls.", "Welp");
                    }
                }
            }
        }

        //User Selection - Whitelist
        //Prompts User to Load An Existing Whitelist
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

        //Whitelist
        //Opens Loaded Whitelist (Notepad.exe)
        private void modifyWListBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", whiteListLocation);
        }

        //ProgressBar
        //Updates extractProgressBar Status
        private void UpdateProgressBar(int lineLength)
        {
            currentLine += 1;
            extractProgressBar.Value = (int)(((decimal)currentLine / (decimal)lineCount) * (decimal)100);
        }

        //ProgressBar
        //Count lines in all selected files
        private void countLines()
        {
            foreach (string fname in fileListingListBox.Items)
            {
                lineCount = File.ReadAllLines(fname).Length;
            }
        }

        //Links
        //ThreatFix Graphic Click
        private void threatBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.threatfix.com");
        }

        //Links
        //ThreatFix Link Clicked
        private void tFixLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.threatfix.com");
        }

    }
}
