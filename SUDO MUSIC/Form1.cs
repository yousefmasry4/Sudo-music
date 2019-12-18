using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        public static IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                .FirstOrDefault();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            var ip = GetDefaultGateway().ToString();
            String[] input = { "192", "168", "1", "100" };
            String[] strlist = ip.Split('.');
            int flag = 0;
            for (int i=0; i<4; i++)
            {
                flag+=strlist[i] == input[i] ? 0 : 1;
                
            }
            if(falg != 0)
            {
                //msh sa7
            }
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
