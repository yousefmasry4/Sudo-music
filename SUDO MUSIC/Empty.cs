using System;
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
    public partial class Empty : Form
    {
        public Empty()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Empty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
