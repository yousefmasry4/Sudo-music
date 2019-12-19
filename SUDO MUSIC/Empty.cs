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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            undersidepanel1.Width = button2.Width;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = TransparencyKey;
            undersidepanel1.SendToBack();
            undersidepanel2.BringToFront();

        }

     

        private void undersidepanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
