using System;
using System.Windows.Forms;

namespace SUDO_MUSIC
{
    public partial class Success : Form
    {
        private int _ticks;
        public Success()
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
                Empty f3 = new Empty();
                //f3.StartPosition = FormStartPosition.CenterScreen;// no need you can toggle this ability from property Startposition
                f3.ShowDialog();
                timer1.Stop();
            }
        }

        private void Success_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
