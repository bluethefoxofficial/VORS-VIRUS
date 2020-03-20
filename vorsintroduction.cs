using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VORS2._0_the_fuckery_countinues
{
    public partial class vorsintroduction : Form
    {
        public vorsintroduction()
        {
            InitializeComponent();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
          Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
        Random r = new Random();
       public int appkillswitchkeypublic;
       public int appkillswitchprivate;
        private void Vorsintroduction_Load(object sender, EventArgs e)
        {
            timer1.Start();
            appkillswitchkeypublic = r.Next(13534, 45689779);
            appkillswitchprivate = appkillswitchkeypublic * 78 / 54 * 99 * appkillswitchkeypublic;
            textBox1.Text = appkillswitchkeypublic.ToString();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.WriteLine("killswitchkey:      " + appkillswitchprivate.ToString());
            
            if(Interaction.InputBox("type your code for deactivation of VORS", "input") == appkillswitchprivate.ToString())
            {
                MessageBox.Show("vors has been deactivated. Goodbye");
                System.Environment.Exit(1);
            }
            else
            {
              
                    MessageBox.Show("Invalid code try again.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
                
           
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label5.Visible = true;
            textBox1.Visible = true;
            linkLabel3.Visible = true;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/bluethefoxyt");
        }
    }


}


