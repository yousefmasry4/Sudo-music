﻿using System;
using System.Windows.Forms;

namespace SUDO_MUSIC
{
    public partial class FAILED : Form
    {
        private int _ticks;
        public int ip { set; get; }
        public FAILED()
        {
            InitializeComponent();
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 1)
            {
                this.Hide();
                Form1 f4 = new Form1();
                
                f4.ShowDialog();
                timer1.Stop();
            }


        }

        private void FAILED_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
