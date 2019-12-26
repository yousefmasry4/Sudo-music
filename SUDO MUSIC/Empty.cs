using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ImageProcessor.Processors;
using ImageProcessor.Imaging;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace SUDO_MUSIC
{

    public partial class Empty : Form
    {
    
        public string s;
        public JObject dataall;
        public Dictionary<string, string> xvalues;

        private async void  dataget()
        {
            MessageBox.Show($"sadsd");
            var url = $"http://{s}/icy";
            using var client = new HttpClient();
            while (true)
            {

                var response = await client.PostAsync(url, null);

                string result = response.Content.ReadAsStringAsync().Result;

                String jsonx = JsonConvert.SerializeObject(result);
                  MessageBox.Show($"{jsonx}");
                var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                string html = string.Empty;
                string url2 = @"https://scraper2.onlineradiobox.com/eg.radioeltekia?l=0";

                HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url2);
                request2.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse())
                using (Stream stream = response2.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                MessageBox.Show(html);
                String json0x = JsonConvert.SerializeObject(html);
                var values2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(html);
                label14.Text = values2["title"]};

                try
                {
                    if (values["meta"] != xvalues["meta"])
                    {
                        label14.Text = values["meta"];

                    }
                    else
                    {
                        xvalues = values;
                    }
                }
                catch
                {
                    label14.Text = values["meta"];

                }
                //  JavaScriptSerializer js = new JavaScriptSerializer();
                // var persons = js.Deserialize<dynamic,dynamic>(jsonx); // Person [] persons =  js.Deserialize<Person[dynamic,dynamic]>(json);
                //   MessageBox.Show($"{values["curst"]}");

                await Task.Delay(8000);
            }
        }

        public  Empty(string s) 
        {
            this.s = s;
            InitializeComponent();
            

            undersidepanel1.BringToFront();
            panelpicbox.BringToFront();
            panelsettings.SendToBack();
            panel1.BackColor = Color.FromArgb(100, Color.Black);
            panel5.BackColor = Color.FromArgb(0, Color.Black);
            panel2.BackColor = Color.FromArgb(100, Color.Black);
            PanelAccess.BackColor = Color.FromArgb(100, Color.Black);
            Panelsoundsettings.BackColor = Color.FromArgb(100, Color.Black);
            WifiPanel.BackColor = Color.FromArgb(100, Color.Black);

            WebRequest request = WebRequest.Create("https://i1.sndcdn.com/artworks-000095590419-kwlwvt-t500x500.jpg");
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBox3.Image = Bitmap.FromStream(str);

                }

            }
           
            
            label4.Text = s;
            label4.Refresh();
            label4.Update();
            dataget();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Empty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            undersidepanel1.Width = button1.Width;

            panelsettings.SendToBack(); undersidepanel2.SendToBack();
            panelpicbox.BringToFront(); undersidepanel1.BringToFront();

            WebRequest request = WebRequest.Create("https://i1.sndcdn.com/artworks-000095590419-kwlwvt-t500x500.jpg");
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBox3.Image = Bitmap.FromStream(str);

                    
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            undersidepanel1.Width = button2.Width;
           
            undersidepanel1.SendToBack();
            undersidepanel2.BringToFront();
            panelpicbox.SendToBack();
            panelsettings.BringToFront();

        }

        private void Soundselector_Click(object sender, EventArgs e)
        {
            panel4.Height = Soundselector.Height;
            panel4.Top = Soundselector.Top;
            WifiPanel.SendToBack(); PanelAccess.SendToBack(); Panelsoundsettings.BringToFront();

        }

        private void Wifi_Click(object sender, EventArgs e)
        {
            panel4.Height = Wifi.Height;
            panel4.Top = Wifi.Top;

            Panelsoundsettings.SendToBack();
            PanelAccess.SendToBack(); 
            WifiPanel.BringToFront();


        }

        private void Access_Click(object sender, EventArgs e)
        {
            panel4.Height = Access.Height;
            panel4.Top = Access.Top;
            Panelsoundsettings.SendToBack(); WifiPanel.SendToBack(); PanelAccess.BringToFront();



        }

        private void SSID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit2_Click(object sender, EventArgs e)
        {

        }

        private void Submit3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Submit1_Click(object sender, EventArgs e)
        {

        }

        private void Empty_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelpicbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
            DialogResult dialogResult = MessageBox.Show("Confirm", "Logging Out?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form1 f6 = new Form1();
                f6.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
