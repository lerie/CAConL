using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace CAConL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void linkWorkrComp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtLicNum.Text.Length > 0)
            {
                System.Diagnostics.Process.Start("https://www2.cslb.ca.gov/OnlineServices/CheckLicenseII/WCHistory.aspx?LicNum=" + txtLicNum.Text);
            }
            else
            {
                MessageBox.Show("Please provide a license number.", "License Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            bwGetLicInfo.RunWorkerAsync(txtLicNum.Text);
        }

        private void bwGetLicInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            bwGetLicInfo.ReportProgress(0, "status;Working..");

            string lic = e.Argument.ToString();
            string url = "https://www2.cslb.ca.gov/OnlineServices/CheckLicenseII/LicenseDetail.aspx?LicNum=" + lic;
            string src = string.Empty;

            string ret = "";

            try
            {
                bwGetLicInfo.ReportProgress(0, "status;Requesting information..");

                WebRequest req = WebRequest.Create(url);
                req.Credentials = CredentialCache.DefaultCredentials;
                ((HttpWebRequest)req).UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:10.0.2) Gecko/20100101 Firefox/10.0.2";

                WebResponse res = req.GetResponse();
                StreamReader rdr = new StreamReader(res.GetResponseStream());
                src = rdr.ReadToEnd();
                rdr.Close();
                res.Close();
            }
            catch (WebException wex)
            {
                MessageBox.Show(wex.Message, "Web Exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "General Exception");
                return;
            }

            bwGetLicInfo.ReportProgress(0, "status;Parsing..");

            Regex rBusInfo = new Regex("id=\"BusInfo\" colspan=\"2\">(.*)<\\/td>");
            Regex rEntity= new Regex("id=\"Entity\">(.*)<\\/td>");
            Regex rIssuDate = new Regex("id=\"IssDt\">(.*)<\\/td>");
            Regex rExpired = new Regex("\">(EXPIRED)<\\/span>");
            Regex rActive = new Regex("\">(ACTIVE)<\\/span>");
            Regex rClass = new Regex("<\\/tr><tr><td><p>(.*)<\\/p><\\/td><td><p><a\\shref=\"(.*)\">(.*)<\\/a>");
            Regex rExpDate = new Regex("id=\"ExpDt\">(\\d{2}\\/\\d{2}\\/\\d{4})<\\/td>");

            try
            {
                MatchCollection mcBusInfo = rBusInfo.Matches(src);
                ret += "bus|" + mcBusInfo[0].Groups[1].Value;

                MatchCollection mcEntity = rEntity.Matches(src);
                ret += "|entity|" + mcEntity[0].Groups[1].Value;

                MatchCollection mcIssueDate = rIssuDate.Matches(src);
                ret += "|issuedate|" + mcIssueDate[0].Groups[1].Value;

                MatchCollection mcClass = rClass.Matches(src);
                ret += "|class|" + mcClass[0].Groups[1].Value + "," + mcClass[0].Groups[3].Value;

                ret += "|active|";

                if (rExpired.Matches(src).Count > 0)
                {
                    ret += "Expired";
                }
                else if (rActive.Matches(src).Count > 0)
                {
                    ret += "Active";
                }
                else
                {
                    ret += "N/A";
                }

                MatchCollection mcExpDate = rExpDate.Matches(src);
                ret += "|expdate|" + mcExpDate[0].Groups[1].Value;

                bwGetLicInfo.ReportProgress(0, "ret;" + ret);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You may have specified an invalid License Number.", "Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtLicNum.Text.Length > 0)
            {
                System.Diagnostics.Process.Start("https://www2.cslb.ca.gov/OnlineServices/CheckLicenseII/LicenseDetail.aspx?LicNum=" + txtLicNum.Text);
            }
            else
            {
                MessageBox.Show("Please provide a license number.", "License Error");
            }
        }

        private void bwGetLicInfo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string[] args = e.UserState.ToString().Split(';');
            switch (args[0])
            {
                case "status":
                    status.Text = args[1];
                    break;

                case "ret":
                    string[] info = args[1].Split('|');

                    txtAddress.Text = prepareAddr(info[1]);
                    txtEntity.Text = info[3];
                    txtIssueDate.Text = info[5];

                    //classifications, there are multiple sometimes, tested up to 2
                    lvClassifications.Items.Clear();
                    List<string> classes = new List<string>() { };

                    //regex the classifications
                    Regex rClassif1 = new Regex("([A-Za-z0-9]{1,3}|\\w-\\d)<\\/p>");
                    Regex rClassif2 = new Regex("<p>([A-Za-z0-9]{1,3})");

                    MatchCollection mcClass1 = rClassif1.Matches(info[7]);
                    MatchCollection mcClass2 = rClassif2.Matches(info[7]);

                    try
                    {
                        classes.Add(mcClass1[0].Groups[1].Value + ",");

                        string[] qtmp = info[7].Split(',');
                        classes.Add(mcClass2[0].Groups[1].Value + "," + qtmp[1]);

                        foreach (string s in classes)
                        {
                            string[] sinfo = s.Split(',');

                            ListViewItem itm = new ListViewItem();
                            itm.Text = sinfo[0];
                            itm.SubItems.Add(sinfo[1]);

                            lvClassifications.Items.Add(itm);
                        }
                    }
                    catch { };

                    txtLicStatus.Text = info[9];
                    txtExpDate.Text = info[11];
                    break;
            }
        }

        public string prepareAddr(string a)
        {
            string ret = string.Empty;
            ret = a.Replace("<br/>", "\r\n");
            ret = a.Replace("<br />", "\r\n");
            return ret;
        }

        private void txtLicStatus_TextChanged(object sender, EventArgs e)
        {
            switch (txtLicStatus.Text)
            {
                case "Active": txtLicStatus.ForeColor = Color.Green; break;
                case "Expired": txtLicStatus.ForeColor = Color.Red; break;
            }
        }

        private void getLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bwGetLicInfo.RunWorkerAsync(txtLicNum.Text);
        }

        private void bwGetLicInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            status.Text = "Waiting..";
        }
    }
}
