using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SUDO_MUSIC
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
         
            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = TransparencyKey;

            


        }
       
        public void textBox1_TextChanged(object sender, EventArgs e)
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
            

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = TransparencyKey;

            var ip = GetDefaultGateway().ToString();
            String[] input = textBox1.Text.Split('.');
            String[] strlist = ip.Split('.');
            int flag = 0;

            if (input.Length == 4)
            {
                for (int i = 0; i < 3; i++)
                {

                    flag += strlist[i] == input[i] ? 0 : 1;

                }
                
                if (flag == 1)
                {
                    this.Hide();
                    FAILED f1 = new FAILED();
                   
                    f1.ShowDialog();
                    

                    flag = 0;
                }
                else if (flag == 0)
                {
                    this.Hide();
                    Success f2 = new Success();
                    
                    f2.ShowDialog();
                    
                    
                   
                    flag = 0;
                }
            } 
            else
                button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = TransparencyKey;

            MessageBox.Show("Enter valid ip");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
