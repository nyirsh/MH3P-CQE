using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using CQE.Classes;

namespace CQE
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();

            label1.Text = "Status:";
            fileLabel.Text = "File:";
            totaleLabel.Text = "Total:";
        }

        private static string lastVersion = "";
        private int dwnStep = 0;
        Dictionary<string, string> filesToDownload = new Dictionary<string, string>();
        private int dwnTot = 0;
        public string LangNotSupported = "";

        private static string cqwAddress = Params.CqwAddress;

        public static int CheckForUpdate()
        {
            try
            {
                WebClient uwc = new WebClient();
                lastVersion = uwc.DownloadString(cqwAddress + "/cqe/version");
                if (lastVersion != Params.CurrentVersion)
                    return 1;
                else
                    return 0;
            }
            catch
            {
                return -1;
            }
        }

        private void Updater_Shown(object sender, EventArgs e)
        {
            try
            {
                if (filesToDownload.Count > 0)
                    filesToDownload.Clear();
                filesToDownload.Add(cqwAddress + "/cqe/MHP3rd CQE.exe", "MHP3rd CQE v" + lastVersion + ".exe");

                statoLabel.Text = "Checking Language Files";
                statoLabel.Refresh();
                Application.DoEvents();

                WebClient wc = new WebClient();
                string langPackets = wc.DownloadString(cqwAddress + "/cqe/lang/langs.php?version=" + lastVersion);
                List<string> Langs = new List<string>();
                Langs.AddRange(langPackets.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                Langs.RemoveAt(Langs.Count - 1);
                Langs.RemoveAt(Langs.Count - 1);
                Langs.RemoveAt(Langs.Count - 1);
                Langs.RemoveAt(Langs.Count - 1);


                // Language Checks
                statoLabel.Text = "Downloading Files List";
                statoLabel.Refresh();
                Application.DoEvents();

                int step = 0;
                string[] allLangPacks = Directory.GetDirectories("Lang", "*", SearchOption.TopDirectoryOnly);
                foreach (string langPack in allLangPacks)
                {
                    if (Langs.Contains(langPack.Substring(5)))
                    {
                        string languageFiles = wc.DownloadString(cqwAddress + "/cqe/lang/langs.php?version=" + lastVersion + "/" + langPack.Substring(5));
                        List<string> allFiles = new List<string>();
                        allFiles.AddRange(languageFiles.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
                        allFiles.RemoveAt(allFiles.Count - 1);
                        allFiles.RemoveAt(allFiles.Count - 1);
                        allFiles.RemoveAt(allFiles.Count - 1);
                        allFiles.RemoveAt(allFiles.Count - 1);
                        foreach (string toDwn in allFiles)
                        {
                            filesToDownload.Add(cqwAddress + "/cqe/lang/" + lastVersion + "/" + langPack.Substring(5) + "/" + toDwn, "Lang" + Path.DirectorySeparatorChar + langPack.Substring(5) + Path.DirectorySeparatorChar + toDwn);
                        }
                    }
                    else
                    {
                        LangNotSupported += "\n" + langPack.Substring(5);
                        //File.AppendAllText("Lang" + Path.DirectorySeparatorChar + "NotSupported", langPack.Substring(5) + "\r\n", Encoding.UTF8);
                    }
                    step++;
                    totalBar.Value = (int)((step / allLangPacks.Length) * 100);
                    totalBar.Refresh();
                    Application.DoEvents();
                }

                // Download All Files
                totalBar.Value = 0;
                totalBar.Refresh();
                Application.DoEvents();

                dwnTot = filesToDownload.Count;
                NextStep();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failure!\nERRORE:\n" + ex.Message, Language.Dictionary["errors"]["title"], MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void NextStep()
        {
            fileBar.Value = 0;
            fileBar.Refresh();
            fileLabel.Text = "File: " + dwnStep + "/" + dwnTot;
            fileLabel.Refresh();
            Application.DoEvents();
            WebClient web = new WebClient();
            web.DownloadFileCompleted += new AsyncCompletedEventHandler(web_DownloadFileCompleted);
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(web_DownloadProgressChanged);

            if (filesToDownload.Count > 0)
            {
                string remoteFile = "";
                string localFile = "";
                foreach (KeyValuePair<string, string> kvp in filesToDownload)
                {
                    remoteFile = kvp.Key;
                    localFile = kvp.Value;
                    break;
                }
                statoLabel.Text = "Downloading File " + localFile;
                statoLabel.Refresh();
                Application.DoEvents();
                web.DownloadFileAsync(new Uri(remoteFile), localFile);
            }
        }

        void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            fileBar.Value = e.ProgressPercentage;
            fileBar.Refresh();
        }

        void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            dwnStep++;
            float temp = (float)dwnStep / (float)dwnTot;
            int percent = (int)(temp * 100);
            totalBar.Value = percent;
            totalBar.Refresh();
            Application.DoEvents();
            totaleLabel.Text = "Total: " + percent + "%";
            totaleLabel.Refresh();
            Application.DoEvents();
            foreach (KeyValuePair<string, string> kvp in filesToDownload)
            {
                filesToDownload.Remove(kvp.Key);
                break;
            }
            if (filesToDownload.Count > 0)
                NextStep();
            else
            {
                try
                {
                    File.Delete("config.ini");
                }
                catch { }
                statoLabel.Text = "-";
                statoLabel.Refresh();
                Application.DoEvents();
                MessageBox.Show("Update Complete!\nVersion: " + lastVersion);
                if (LangNotSupported.Length > 0)
                    MessageBox.Show("Those language packages are not\ncompatible with the new version of CQE.\nPlease wait for their release.\nLanguages: " + LangNotSupported);
                Process.Start("MHP3rd CQE v" + lastVersion + ".exe");
                Application.Exit();
            }
        }
    }
}
