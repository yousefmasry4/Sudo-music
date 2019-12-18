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
    public partial class FAILED : Form
    {
        private int _ticks;
        public int ip { set; get; }
        public FAILED()
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
                Form1 f4 = new Form1();
                f4.ShowDialog();
                timer1.Stop();
            }


        }    
    }
}
