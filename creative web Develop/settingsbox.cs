﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creative_web_Develop
{
    public partial class settingsbox : Form
    {
        public settingsbox()
        {
            InitializeComponent();
        }

        private void settingsbox_Load(object sender, EventArgs e)
        {

        }
        private void Form1_HelpButtonClicked(Object sender, CancelEventArgs e)

        {

            MessageBox.Show("CDW Help", "Beta versions of CDW dont have help in them.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TestFTPconnectionbtn_Click(object sender, EventArgs e)
        {
            Status.Text = "status: Connecting";
            pictureBox1.BackColor = Color.Orange; 
            FtpWebRequest requestDir = (FtpWebRequest)FtpWebRequest.Create("ftp://" + textBox1.Text + ":" + numericUpDown1.Value);
            requestDir.Credentials = new NetworkCredential(textBox2.Text, textBox3.Text);

            try
            {
                WebResponse response = requestDir.GetResponse();
                Status.Text = "connection successfull";
                pictureBox1.BackColor = Color.Green;
            }
            catch (Exception)
            {
                Status.Text = "connection unsuccessfull";
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Applysettings_Click(object sender, EventArgs e)
        {

        
        }
    }
}
