﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string myConnection = "";

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 註冊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.Show();
        }
    }
}
