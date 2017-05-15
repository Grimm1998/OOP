﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEx_1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Lab_5_Ex_1 FormEx_1 = new Lab_5_Ex_1(this);
            FormEx_1.Show();
        }

        private void btnEx_2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Lab_5_Ex_2 FormEx_2 = new Lab_5_Ex_2(this);
            FormEx_2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}