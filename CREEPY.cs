using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VORS2._0_the_fuckery_countinues
{
    public partial class CREEPY : Form
    {
        public CREEPY()
        {
            InitializeComponent();
        }

        private void CREEPY_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void CREEPY_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Scary);
            simpleSound.Play();
            timer1.Start();
            Random rand = new Random();
            if (rand.Next(0, 1) == 1)
            {
                BackgroundImage = Properties.Resources.creepy_face_coin_bank;
            }
            else
            {
                BackgroundImage = Properties.Resources.EAu4xxAWkAAdcdi;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
