﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUDO_MUSIC
{
    
    public partial class Form1 : Form
    {
        public int ip { set; get; }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ip = int.Parse(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ip==0)
            {
                this.Hide();
                FAILED f1 = new FAILED();
                f1.ShowDialog();
            }
            else if(ip==1)
            {
                this.Hide();
                Success f2 = new Success();
                f2.ShowDialog();

            }
        }
    }
}
