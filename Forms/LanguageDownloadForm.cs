using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using CQE.Classes;
using CQE.Controls;

namespace CQE
{
    public partial class LanguageDownloadForm : Form
    {
        public Dictionary<string, string> filesToDownload = new Dictionary<string, string>();
        private static string cqwAddress = Params.CqwAddress;

        public LanguageDownloadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                try
                {
                    string alreadyInstalled = "";
                    WebClient wc = new WebClient();
                    foreach (MyListBoxItem mlbi in listBox1.SelectedItems)
                    {
                        string langPack = mlbi.Text;
                        if (!Directory.Exists("Lang" + Path.DirectorySeparatorChar + langPack))
                        {
                            Directory.CreateDirectory("Lang" + Path.DirectorySeparatorChar + langPack);
                            string languageFiles = wc.DownloadString(cqwAddress + "/cqe/lang/langs.php?version=" + Params.CurrentVersion + "/" + langPack);
                            List<string> allFiles = new List<string>();
                            allFiles.AddRange(languageFiles.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                            allFiles.RemoveAt(allFiles.Count - 1);
                            allFiles.RemoveAt(allFiles.Count - 1);
                            allFiles.RemoveAt(allFiles.Count - 1);
                            allFiles.RemoveAt(allFiles.Count - 1);
                            foreach (string toDwn in allFiles)
                            {
                                filesToDownload.Add(cqwAddress + "/cqe/lang/" + Params.CurrentVersion + "/" + langPack + "/" + toDwn, "Lang" + Path.DirectorySeparatorChar + langPack + Path.DirectorySeparatorChar + toDwn);
                            }
                        }
                        else
                        {
                            alreadyInstalled += "\n" + langPack;
                        }
                    }

                    if (alreadyInstalled != "")
                        MessageBox.Show("These languages are already installed and will not be downloaded.\nLanguages:" + alreadyInstalled + "\nIf you want to redownload them, please delete them first.");

                    int Total = filesToDownload.Count;
                    int Step = 0;

                    if (Total > 0)
                    {
                        foreach (KeyValuePair<string, string> kvp in filesToDownload)
                        {
                            string remoteFile = kvp.Key;
                            string localFile = kvp.Value;
                            if (localFile.Contains("flag.png"))
                            {
                                byte[] flag = wc.DownloadData(remoteFile);
                                File.WriteAllBytes(localFile, flag);
                            }
                            else
                            {
                                wc.DownloadFile(new Uri(remoteFile), localFile);
                            }
                            Step++;
                            float temp = (float)Step / (float)Total;
                            int percent = (int)(temp * 100);
                            TotalBar.Value = percent;
                            TotalBar.Refresh();
                            TotalLabel.Text = "Total: " + percent + "%";
                            TotalLabel.Refresh();
                            Application.DoEvents();
                        }
                        MessageBox.Show("Download Complete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while connecting to Server.\nERROR:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }

        private void LanguageDownloadForm_Shown(object sender, EventArgs e)
        {
            try
            {
                listBox1.ImageList.ImageSize = new System.Drawing.Size(22, 16);
                WebClient wc = new WebClient();
                string langPackets = wc.DownloadString(cqwAddress + "/cqe/lang/langs.php?version=" + Params.CurrentVersion);
                List<string> Langs = new List<string>();
                Langs.AddRange(langPackets.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                Langs.RemoveAt(Langs.Count - 1);
                Langs.RemoveAt(Langs.Count - 1);
                Langs.RemoveAt(Langs.Count - 1);
                Langs.RemoveAt(Langs.Count - 1);
                Langs.Sort();

                int index = 0;
                foreach (string lang in Langs)
                {
                    byte[] flag = wc.DownloadData(cqwAddress + "/cqe/lang/" + Params.CurrentVersion + "/" + lang + "/flag.png");
                    MemoryStream ms = new MemoryStream(flag);
                    listBox1.ImageList.Images.Add(Image.FromStream(ms));
                    listBox1.Items.Add(new MyListBoxItem(lang, index));
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to Server.\nERROR:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
