using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VORS2._0_the_fuckery_countinues
{
    public partial class msb : Form
    {
        public msb()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.Location = new Point(rand.Next(0,ClientSize.Width + rand.Next(0,1080)), rand.Next(0,ClientSize.Height + rand.Next(0,1920)));
        }

        private void Msb_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
