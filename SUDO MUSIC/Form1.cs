using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hello world 2

namespace SUDO_MUSIC
{


    public partial class Form1 : Form
    {
        public string ip { set; get; }
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "0")
            {
                this.Hide();
                FAILED f1 = new FAILED();
                f1.ShowDialog();
            }
            else if (textBox1.Text == "1")
            {
                this.Hide();
                Success f2 = new Success();
                f2.ShowDialog();

            }
            else

                MessageBox.Show("Enter a valid ip");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
