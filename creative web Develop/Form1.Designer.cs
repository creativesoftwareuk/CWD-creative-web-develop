﻿namespace creative_web_Develop
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
            this.components = new System.ComponentModel.Container();
            this.lblversion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxDoubleBuffer1 = new creative_web_Develop.PictureBoxDoubleBuffer();
            this.cxFlatAlertBox1 = new CxFlatUI.CxFlatAlertBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoubleBuffer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.BackColor = System.Drawing.Color.Transparent;
            this.lblversion.Font = new System.Drawing.Font("Alef", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblversion.Location = new System.Drawing.Point(981, 593);
            this.lblversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(57, 19);
            this.lblversion.TabIndex = 0;
            this.lblversion.Text = "0.0.0.0";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxDoubleBuffer1
            // 
            this.pictureBoxDoubleBuffer1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDoubleBuffer1.DoubleBuffered = true;
            this.pictureBoxDoubleBuffer1.Image = global::creative_web_Develop.Properties.Resources.WARNING1;
            this.pictureBoxDoubleBuffer1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDoubleBuffer1.Name = "pictureBoxDoubleBuffer1";
            this.pictureBoxDoubleBuffer1.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxDoubleBuffer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoubleBuffer1.TabIndex = 1;
            this.pictureBoxDoubleBuffer1.TabStop = false;
            this.pictureBoxDoubleBuffer1.Visible = false;
            // 
            // cxFlatAlertBox1
            // 
            this.cxFlatAlertBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cxFlatAlertBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cxFlatAlertBox1.Location = new System.Drawing.Point(75, 24);
            this.cxFlatAlertBox1.Name = "cxFlatAlertBox1";
            this.cxFlatAlertBox1.Size = new System.Drawing.Size(963, 34);
            this.cxFlatAlertBox1.TabIndex = 2;
            this.cxFlatAlertBox1.Type = CxFlatUI.CxFlatAlertBox.AlertType.Error;
            this.cxFlatAlertBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::creative_web_Develop.Properties.Resources.CWD_NEW_SPLASH;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 636);
            this.Controls.Add(this.cxFlatAlertBox1);
            this.Controls.Add(this.pictureBoxDoubleBuffer1);
            this.Controls.Add(this.lblversion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDEVWEB";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoubleBuffer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Timer timer1;
        private PictureBoxDoubleBuffer pictureBoxDoubleBuffer1;
        private CxFlatUI.CxFlatAlertBox cxFlatAlertBox1;
    }
}

