using System;

using System.Windows.Forms;


namespace SUDO_MUSIC
{
    public partial class Empty : Form
    {
        public Empty()
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = TransparencyKey;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = TransparencyKey;
            undersidepanel1.BringToFront();
            panelpicbox.BringToFront();
            panelsettings.SendToBack();
            Soundselector.FlatStyle = FlatStyle.Flat;
            Soundselector.FlatAppearance.BorderSize = 0;
            Soundselector.FlatAppearance.BorderColor = TransparencyKey;
            Wifi.FlatStyle = FlatStyle.Flat;
            Wifi.FlatAppearance.BorderSize = 0;
            Wifi.FlatAppearance.BorderColor = TransparencyKey;
            Access.FlatStyle = FlatStyle.Flat;
            Access.FlatAppearance.BorderSize = 0;
            Access.FlatAppearance.BorderColor = TransparencyKey;
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
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = TransparencyKey;
            undersidepanel2.SendToBack();
            undersidepanel1.BringToFront();
            panelpicbox.BringToFront();
            panelsettings.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            undersidepanel1.Width = button2.Width;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = TransparencyKey;
            undersidepanel1.SendToBack();
            undersidepanel2.BringToFront();
            panelpicbox.SendToBack();
            panelsettings.BringToFront();
            
        }

        private void Soundselector_Click(object sender, EventArgs e)
        {
            Soundselector.FlatStyle = FlatStyle.Flat;
            Soundselector.FlatAppearance.BorderSize = 0;
            Soundselector.FlatAppearance.BorderColor = TransparencyKey;
            WifiPanel.SendToBack();
            PanelAccess.SendToBack();
            Panelsoundsettings.BringToFront();
            
        }

        private void Wifi_Click(object sender, EventArgs e)
        {
            Wifi.FlatStyle = FlatStyle.Flat;
            Wifi.FlatAppearance.BorderSize = 0;
            Wifi.FlatAppearance.BorderColor = TransparencyKey;
            PanelAccess.SendToBack();
            Panelsoundsettings.SendToBack();
            WifiPanel.BringToFront();
        }

        private void Access_Click(object sender, EventArgs e)
        {
            Access.FlatStyle = FlatStyle.Flat;
            Access.FlatAppearance.BorderSize = 0;
            Access.FlatAppearance.BorderColor = TransparencyKey;
            Panelsoundsettings.SendToBack();
            WifiPanel.SendToBack();
            PanelAccess.BringToFront();

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
    }
}
