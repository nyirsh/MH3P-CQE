using System;
using System.Windows.Forms;
using CQE.Classes;

namespace CQE
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();

            Text = Language.Dictionary["menu"]["credits"];
            label1.Text = "Version: " + Params.CurrentVersion;
            if (!Configs.CurrentLanguage.ToLower().Contains("it"))
                label5.Text = Configs.CurrentLanguage + " Language Pack translated by " + Configs.LanguageTranslater;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Params.CqwAddress);
            Close();
        }
    }
}
