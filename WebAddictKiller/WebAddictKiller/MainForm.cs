using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Collections;
using System.Diagnostics;

namespace WebAddictKiller
{
    public partial class MainForm : Form
    {
        //private List<AddictedWebsite> addictedWebsites;
        //struct AddictedWebsite
        //{
        //    public string url;
        //    public bool selected;
        //}

        private string addictionDataPath = @"c:\windows\addictionData.xml";
        private static XPathDocument doc;
        private static XPathNavigator nav;
        private static string version = "Web Addict Killer Version 0.1";

        private string beginString, endString, regexString;//for recognizing modified file parts
        private string hostsPath = @"c:\windows\system32\drivers\etc\hosts";//hosts file

        private WebsiteAdditionForm addForm = null;

        public MainForm()
        {
            InitializeComponent();
            beginString = "#" + version;
            endString = "#end";
            regexString = "(?s)" + beginString + "(.*(\r\n)*)+" + endString;

            writeInitialAddictionDatabase();
            doc = new XPathDocument(addictionDataPath);
            nav = ((IXPathNavigable)doc).CreateNavigator();

            readFromAddictionDatabase();
        }

        private void writeInitialAddictionDatabase()
        {
            FileInfo fileInfo = new FileInfo(addictionDataPath);
            if (!fileInfo.Exists)
            {
                XmlTextWriter textWriter = new XmlTextWriter(addictionDataPath, null);

                // Opens the document
                textWriter.WriteStartDocument();

                // Write comments
                textWriter.WriteComment("Web addiction data");
                // Write first element
                textWriter.WriteStartElement("WebAddictionRecord");

                textWriter.WriteStartElement("Website");
                textWriter.WriteStartAttribute("Selected");
                textWriter.WriteString("True");
                textWriter.WriteEndAttribute();
                textWriter.WriteString("bbs.sjtu.edu.cn");
                textWriter.WriteEndElement();

                // Ends the document.
                textWriter.WriteEndDocument();
                // close writer
                textWriter.Close();
            }
        }

        private void readFromAddictionDatabase()
        {
            // Create an instance of XmlTextReader and call Read method to read the file
            XmlTextReader textReader = new XmlTextReader(addictionDataPath);

            XPathNodeIterator itWMobileRegNode = nav.Select(@"//Website");

            // add to GUI
            foreach (XPathNavigator navReg in itWMobileRegNode)
            {
                websiteCheckedListBox.Items.Add(navReg.Value, Boolean.Parse(navReg.GetAttribute("Selected", "")));
            }
        }

        //hosts file has pattern
        private bool hasPattern()
        {
            string str = System.IO.File.ReadAllText(hostsPath);

            Regex reg = new Regex(regexString);
            Match mat = reg.Match(str);
            Debug.WriteLine(mat.Value);
            return mat.Success;
        }

        //replace designated pattern in system hosts file with hostsInformation
        private void updateDNSHosts(string hostsInformation)
        {
            if (!hasPattern())
            {
                using (StreamWriter sw = File.AppendText(hostsPath))
                {
                    sw.Write(hostsInformation);
                }
            }
            else
            {
                string str = System.IO.File.ReadAllText(hostsPath);

                Regex reg = new Regex(regexString);
                //replace matched substring
                str = reg.Replace(str, hostsInformation);

                using (StreamWriter sw = new StreamWriter(hostsPath))
                {
                    sw.Write(str);
                }
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            StringBuilder hostsSB = new StringBuilder();
            hostsSB.AppendLine(beginString);

            for (int i = 0; i < websiteCheckedListBox.Items.Count; i++)
            {
                if (this.websiteCheckedListBox.GetItemChecked(i))
                {
                    hostsSB.AppendLine("127.0.0.1 " + websiteCheckedListBox.GetItemText(websiteCheckedListBox.Items[i]));
                }
            }
            hostsSB.Append(endString);
            updateDNSHosts(hostsSB.ToString());
            updateAddictionDatabase();

            MessageBox.Show("YOU GET RID OF WEB ADDICTION!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            updateDNSHosts("");
            updateAddictionDatabase();
            MessageBox.Show("YOU ARE LOSER ONCE AGAIN!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateAddictionDatabase()
        {
            XmlTextWriter textWriter = new XmlTextWriter(addictionDataPath, null);

            // Opens the document
            textWriter.WriteStartDocument();

            // Write comments
            textWriter.WriteComment("Web addiction data");
            // Write first element
            textWriter.WriteStartElement("WebAddictionRecord");

            for (int i = 0; i < websiteCheckedListBox.Items.Count; i++)
            {
                textWriter.WriteStartElement("Website");
                textWriter.WriteStartAttribute("Selected");
                textWriter.WriteString(websiteCheckedListBox.GetItemChecked(i).ToString());
                textWriter.WriteEndAttribute();

                textWriter.WriteString(websiteCheckedListBox.GetItemText(websiteCheckedListBox.Items[i]));
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();

            // Ends the document.
            textWriter.WriteEndDocument();
            // close writer
            textWriter.Close();
        }

        private bool isURL(string url)
        {
            return true;
        }

        private void buttonAddNewWebsite_Click(object sender, EventArgs e)
        {
            addForm = new WebsiteAdditionForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string url = addForm.url;
                websiteCheckedListBox.Items.Add(addForm.url, true);
            }
            updateAddictionDatabase();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < websiteCheckedListBox.Items.Count; i++)
            {
                this.websiteCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void buttonDeleteFromList_Click(object sender, EventArgs e)
        {
            websiteCheckedListBox.Items.Remove(websiteCheckedListBox.SelectedItem);
            updateAddictionDatabase();
        }

    }
}
