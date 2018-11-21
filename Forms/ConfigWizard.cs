using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CQE.Classes;
using CQE.Controls;

namespace CQE
{
    public partial class ConfigWizard : Form
    {
        public ConfigWizard()
        {
            InitializeComponent();
            RefreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    if (File.Exists(Configs.ConfigFile))
                        File.Delete(Configs.ConfigFile);

                    File.WriteAllText(Configs.ConfigFile, "Lang=" + listBox1.SelectedItem.ToString(), Encoding.UTF8);

                    if (checkBox1.Checked)
                        File.AppendAllText(Configs.ConfigFile, "\r\nAutoUpdate=1");

                    // Clearing Resources before closing the form
                    listBox1.Dispose();
                    this.Close();
                }
                else
                    MessageBox.Show("Please select a language first.", "CQE - Warning");
            }
            catch { }
        }

        private void RefreshList()
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.ImageList.Images.Clear();

                string[] languages = Directory.GetDirectories("Lang", "*", SearchOption.TopDirectoryOnly);

                listBox1.ImageList.ImageSize = new System.Drawing.Size(22, 16);

                int index = 0;
                foreach (string language in languages)
                {
                    if (!language.Contains("#"))
                    {
                        listBox1.ImageList.Images.Add(Image.FromFile(language + Path.DirectorySeparatorChar + "flag.png"));
                        listBox1.Items.Add(new MyListBoxItem(language.Substring(5), index));
                        index++;
                    }
                }
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LanguageDownloadForm ldf = new LanguageDownloadForm();
            //ldf.ShowDialog();
            RefreshList();
        }
    }
}
