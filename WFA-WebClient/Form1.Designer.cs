﻿namespace WFA_WebClient
{
    partial class Form1
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload2 = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.btnDownload3 = new System.Windows.Forms.Button();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnZipPW = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(93, 30);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // btnDownload2
            // 
            this.btnDownload2.Location = new System.Drawing.Point(111, 12);
            this.btnDownload2.Name = "btnDownload2";
            this.btnDownload2.Size = new System.Drawing.Size(110, 30);
            this.btnDownload2.TabIndex = 3;
            this.btnDownload2.Text = "Download 2";
            this.btnDownload2.UseVisualStyleBackColor = true;
            this.btnDownload2.Click += new System.EventHandler(this.btnDownload2_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(26, 164);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(46, 17);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "label1";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.Location = new System.Drawing.Point(115, 164);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(46, 17);
            this.labelPerc.TabIndex = 5;
            this.labelPerc.Text = "label1";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.Location = new System.Drawing.Point(195, 164);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(46, 17);
            this.labelDownloaded.TabIndex = 5;
            this.labelDownloaded.Text = "label1";
            // 
            // btnDownload3
            // 
            this.btnDownload3.Location = new System.Drawing.Point(12, 48);
            this.btnDownload3.Name = "btnDownload3";
            this.btnDownload3.Size = new System.Drawing.Size(115, 30);
            this.btnDownload3.TabIndex = 3;
            this.btnDownload3.Text = "Download 3";
            this.btnDownload3.UseVisualStyleBackColor = true;
            this.btnDownload3.Click += new System.EventHandler(this.btnDownload3_Click);
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(133, 52);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 6;
            this.btnZip.Text = "Zip";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnZipPW
            // 
            this.btnZipPW.Location = new System.Drawing.Point(133, 81);
            this.btnZipPW.Name = "btnZipPW";
            this.btnZipPW.Size = new System.Drawing.Size(75, 23);
            this.btnZipPW.TabIndex = 7;
            this.btnZipPW.Text = "Zip PW";
            this.btnZipPW.UseVisualStyleBackColor = true;
            this.btnZipPW.Click += new System.EventHandler(this.btnZipPW_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(52, 84);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 8;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 176);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnZipPW);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.btnDownload3);
            this.Controls.Add(this.btnDownload2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload2;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.Button btnDownload3;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnZipPW;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

