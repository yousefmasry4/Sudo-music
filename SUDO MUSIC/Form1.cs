using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Web;



namespace SUDO_MUSIC
{
   
    public partial class Form1 : Form
    {
     
        public Form1()
        {
         
            InitializeComponent();
            label1.Hide();


        }

        
        async static  Task<HttpStatusCode> myfuckingfuction(String url)
           {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        return response.StatusCode ;


                    }

                }

            }
            catch(Exception e)
            {
                MessageBox.Show($"{e}   {url}");
                return HttpStatusCode.BadRequest;
            }
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
         
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            label1.Show();
           

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
                //http://192.168.43.100/
                HttpStatusCode xx = await myfuckingfuction($"http://{textBox1.Text}/");
                if (xx == HttpStatusCode.OK && (flag == 1 || flag == 0))
                {
                    // MessageBox.Show("Connecting..." );
                  //  MessageBox.Show(string.Format("{0}", xx));


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
                        Success f2 = new Success(textBox1.Text);

                        f2.ShowDialog();



                        flag = 0;
                        label1.Hide();
                        button1.Show();
                    }
                }
                else
                {
                    label1.Hide();

                    button1.Show();

                    MessageBox.Show($"error ,{xx.ToString()}");

                }

            }

            else
            {
                MessageBox.Show("Enter valid ip");
                    label1.Hide();
                button1.Show();


            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
