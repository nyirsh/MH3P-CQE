using CQE.Controls;

namespace CQE
{
    partial class LanguageDownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new MyListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(202, 134);
            this.listBox1.ItemHeight = 20;
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avaible Languages:";
            // 
            // TotalBar
            // 
            this.TotalBar.Location = new System.Drawing.Point(12, 196);
            this.TotalBar.Name = "TotalBar";
            this.TotalBar.Size = new System.Drawing.Size(202, 23);
            this.TotalBar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 177);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "Total:";
            // 
            // LanguageDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 224);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(243, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(243, 262);
            this.Name = "LanguageDownloadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Language Download";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.LanguageDownloadForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MyListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar TotalBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalLabel;
    }
}