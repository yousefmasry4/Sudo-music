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
using System.Diagnostics;

namespace SUDO_MUSIC
{

    public partial class Empty : Form
    {
        int anafeen = 0;
        String[] arr = new String[5];
        public string s, c = "https://steamuserimages-a.akamaihd.net/ugc/956353893724749105/F5891C490EEE95F62C8CC60B7315EA7DA1258966/?imw=637&imh=358&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true";
        public JObject dataall;
        public Dictionary<string, string> xvalues;

        private async void dataget()
        {
            //  MessageBox.Show($"sadsd");
            var url = $"http://{s}/icy";
            using var client = new HttpClient();
            while (true && anafeen == 1)
            {
                string html = string.Empty;
                string url2 = @"https://scraper2.onlineradiobox.com/eg.masrelgdida?l=0";

                HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url2);
                request2.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse())
                using (Stream stream = response2.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                // MessageBox.Show(html);
                String json0x = JsonConvert.SerializeObject(html);
                var values2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(html);
                values2["title"] = values2["title"].Replace("#", ""); values2["title"] = values2["title"].Replace("-", "");

                label14.Text = values2["title"];
                //  JavaScriptSerializer js = new JavaScriptSerializer();
                // var persons = js.Deserialize<dynamic,dynamic>(jsonx); // Person [] persons =  js.Deserialize<Person[dynamic,dynamic]>(json);
                //   MessageBox.Show($"{values["curst"]}");
                //https://api-v2.soundcloud.com/search?q=%D9%81%D9%8A%D9%84%D9%88&sc_a_id=6cd98100d8f6b12b0663a2f5d724eff7787bbda7&variant_ids=&facet=model&user_id=780962-98040-16331-893890&client_id=FnJDg9sbLbDFKFL01ySCYBqcwZeRDxZj&limit=20&offset=0&linked_partitioning=1&app_version=1576575024&app_locale=en&fbclid=IwAR0GLU7CDjC6WVwmZDjnH5Sr0W_zTBy4Tpran_ysOIwr4JtvSC9sJYoBgbM

                string html2 = string.Empty;
                String url22 = String.Format(@"https://api-v2.soundcloud.com/search?q={0}&sc_a_id=6cd98100d8f6b12b0663a2f5d724eff7787bbda7&variant_ids=&facet=model&user_id=780962-98040-16331-893890&client_id=FnJDg9sbLbDFKFL01ySCYBqcwZeRDxZj&limit=20&offset=0&linked_partitioning=1&app_version=1576575024&app_locale=en&fbclid=IwAR0GLU7CDjC6WVwmZDjnH5Sr0W_zTBy4Tpran_ysOIwr4JtvSC9sJYoBgbM", values2["title"]);
                //MessageBox.Show(url22);

                HttpWebRequest request22 = (HttpWebRequest)WebRequest.Create(url22);
                request22.AutomaticDecompression = DecompressionMethods.GZip;
                try
                {
                    using (HttpWebResponse response22 = (HttpWebResponse)request22.GetResponse())
                    using (Stream stream23 = response22.GetResponseStream())
                    using (StreamReader reader22 = new StreamReader(stream23))
                    {
                        html2 = reader22.ReadToEnd();
                    }

                    String json0x2 = JsonConvert.SerializeObject(html2);
                    var values22 = JsonConvert.DeserializeObject<Dictionary<String, dynamic>>(html2);
                    var a = values22["collection"];
                    var b = a[0];
                    c = b["artwork_url"];
                    c = c.Replace("large", "t500x500");
                }
                catch
                {
                    c = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQBuBrpFbyxzWF7PChfvsZP-iZTze3t2I0VRu7KFmZuBr54gvkx";
                }
                WebRequest request = WebRequest.Create(c);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pictureBox3.Image = Bitmap.FromStream(str);


                    }

                }
                //   MessageBox.Show(c);
                pictureBox3.Update();
                pictureBox3.Refresh();
                await Task.Delay(8000);
            }



        }

        public Empty(string s)
        {
            anafeen = 1;
            this.s = s;
            InitializeComponent();
            trackBarMain.Maximum = 254;
            trackBarMain.Minimum = 0;
            trackBar1.Maximum = 7;
            trackBar1.Minimum = -8;
            trackBar2.Maximum = 15;
            trackBar2.Minimum = 1;
            trackBar3.Maximum = 15;
            trackBar3.Minimum = 0;
            trackBar4.Maximum = 15;
            trackBar4.Minimum = 2;
            trackBar5.Maximum = 3;
            trackBar5.Minimum = 0;
            undersidepanel1.BringToFront();
            panelpicbox.BringToFront();
            panelsettings.SendToBack();
            panel1.BackColor = Color.FromArgb(100, Color.Black);
            panel5.BackColor = Color.FromArgb(0, Color.Black);
            panel2.BackColor = Color.FromArgb(100, Color.Black);

            Panelsoundsettings.BackColor = Color.FromArgb(100, Color.Black);

/*
            WebRequest request = WebRequest.Create(c);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    pictureBox3.Image = Bitmap.FromStream(str);
                    pictureBox3.Update();
                    pictureBox3.Refresh();

                }

            }
            */

            label4.Text = s;
            label4.Refresh();
            label4.Update();

        }
        public static async Task goAsync(String url, Dictionary<string, string> dict)
        {

            var client = new HttpClient();
            var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(dict) };
            var res = await client.SendAsync(req);
            //  MessageBox.Show($"{res.StatusCode}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void Empty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            undersidepanel1.Width = button1.Width;

            panelsettings.SendToBack(); undersidepanel2.SendToBack();
            panelpicbox.BringToFront(); undersidepanel1.BringToFront();

            WebRequest request = WebRequest.Create(c);
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
            Panelsoundsettings.BringToFront();

        }







        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Submit1_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("bass", $"{arr[0]}$");
            dict.Add("treble", $"{arr[1]}$");
            dict.Add("bassfreq", $"{arr[2]}a");
            dict.Add("treblefreq", $"{arr[3]}&");
            dict.Add("spacial", $"{arr[4]}&");

            goAsync($"http://{s}/sound", dict);
            Thread.Sleep(1500);

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

       


        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBarMain_ScrollAsync(object sender, EventArgs e)
        {
            int xv = trackBarMain.Value;
            // MessageBox.Show($"http://{s}/soundvol {xv}");
            var dict = new Dictionary<string, string>();
            dict.Add("vol", $"{xv}$");
            goAsync($"http://{s}/soundvol", dict);
            Thread.Sleep(1500);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Treble control:
            arr[0] = $"{trackBar1.Value}";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //Treble frequency;
            arr[1] = $"{trackBar2.Value}";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            //Bass enhance:
            arr[2] = $"{trackBar3.Value}";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            //Bass frequency:;
            arr[3] = $"{trackBar4.Value}";
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            //Spacialization:
            arr[4] = $"{trackBar5.Value}";
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("id", $"1$");
            goAsync($"http://{s}/play", dict);
            Thread.Sleep(2000);
            button4.Visible = false;
            dataget();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}