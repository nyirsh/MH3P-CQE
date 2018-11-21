namespace CQE
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.label1 = new System.Windows.Forms.Label();
            this.statoLabel = new System.Windows.Forms.Label();
            this.fileBar = new System.Windows.Forms.ProgressBar();
            this.totalBar = new System.Windows.Forms.ProgressBar();
            this.totaleLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stato:";
            // 
            // statoLabel
            // 
            this.statoLabel.AutoSize = true;
            this.statoLabel.Location = new System.Drawing.Point(12, 25);
            this.statoLabel.Name = "statoLabel";
            this.statoLabel.Size = new System.Drawing.Size(10, 13);
            this.statoLabel.TabIndex = 1;
            this.statoLabel.Text = "-";
            // 
            // fileBar
            // 
            this.fileBar.Location = new System.Drawing.Point(15, 65);
            this.fileBar.Name = "fileBar";
            this.fileBar.Size = new System.Drawing.Size(257, 23);
            this.fileBar.TabIndex = 2;
            // 
            // totalBar
            // 
            this.totalBar.Location = new System.Drawing.Point(15, 110);
            this.totalBar.Name = "totalBar";
            this.totalBar.Size = new System.Drawing.Size(257, 23);
            this.totalBar.TabIndex = 3;
            // 
            // totaleLabel
            // 
            this.totaleLabel.AutoSize = true;
            this.totaleLabel.Location = new System.Drawing.Point(12, 94);
            this.totaleLabel.Name = "totaleLabel";
            this.totaleLabel.Size = new System.Drawing.Size(40, 13);
            this.totaleLabel.TabIndex = 4;
            this.totaleLabel.Text = "Totale:";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 49);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 5;
            this.fileLabel.Text = "File:";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.ControlBox = false;
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.totaleLabel);
            this.Controls.Add(this.totalBar);
            this.Controls.Add(this.fileBar);
            this.Controls.Add(this.statoLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 184);
            this.MinimumSize = new System.Drawing.Size(300, 184);
            this.Name = "Updater";
            this.Text = "Updater";
            this.Shown += new System.EventHandler(this.Updater_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statoLabel;
        private System.Windows.Forms.ProgressBar fileBar;
        private System.Windows.Forms.ProgressBar totalBar;
        private System.Windows.Forms.Label totaleLabel;
        private System.Windows.Forms.Label fileLabel;
    }
}