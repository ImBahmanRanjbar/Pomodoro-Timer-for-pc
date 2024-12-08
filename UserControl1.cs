using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int s, m, h;
        int t1 = 0;
        int t2 = 0;
        string status = "Start";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s >= 0)
            {

                s--;
                if (s == 01)
                {
                    t1 = s;
                }


                
                richmin.Text = $"{m.ToString("00")}";
                richsec.Text = $"{s.ToString("00")}";
            }
            if (s == -1)
            {
                s = 0;
               
                richmin.Text = $"{m.ToString("00")}";
                richsec.Text = $"{s.ToString("00")}";
            }

            if (s == 60)
            {
                s = 0;

                m++;
                if (m == 60)
                {
                    m = 0;
                    h++;

                }
            }
            if (s <= 0)
            {
                if (m > 0 || h > 0)
                {
                    if (m == 0)
                    {
                        if (h >= 0)
                        {
                            h--;
                            m = 60;
                            if (h < 0)
                            {
                                h = 0;

                                if (h == 0 && m == 0 && s == 0)
                                {
                                   
                                    richmin.Text = $"{m.ToString("00")}";
                                    richsec.Text = $"{s.ToString("00")}";
                                    timer1.Stop();


                                }

                            }
                        }

                    }
                    m--;
                    s = 59;
                    timer1 = new Timer();
                    timer1.Interval = 1000;
                    timer1.Start();
                
                    richmin.Text = $"{m.ToString("00")}";
                    richsec.Text = $"{s.ToString("00")}";

                    if (m < 0)
                    {
                        m = 0;
                    }
                    if (s < 0)
                    {
                        s = 0;

                    }


                    if (h == 0 && m == 0 && s == 0)
                    {
                        timer1.Stop();
                      
                        richmin.Text = $"{m.ToString("00")}";
                        richsec.Text = $"{s.ToString("00")}";
                       Environment.Exit(0);


                    }
                }
                timer1.Stop();

                System.Media.SoundPlayer p3 = new System.Media.SoundPlayer(Properties.Resources.alarm_clock_beep);
                p3.Play();
                if (h == 0 && m == 0 && s == 0)
                {
                    if (status == "Start")
                    {
                        status = "p";

                        timer1.Start();
                    }
                    else
                    {
                        status = "Start";

                        timer1.Stop();
                        Environment.Exit(0);
                       
                    }

                }
                timer1.Stop();
                System.Media.SoundPlayer p1 = new System.Media.SoundPlayer(Properties.Resources.alarm_clock_beep);
                p1.Play();

                richsec.ReadOnly = false;
                richmin.ReadOnly = false;
                
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int s = 0, m = 0, h = 0;
       
            richmin.Text = $"{m.ToString("00")}";
            richsec.Text = $"{s.ToString("00")}";
            status = "Start";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            s = 0;
            m = 5;
            h = 0;
            if (status== "Start")
            {
                status = "p";
                timer1.Start();
            }
            else
            {
                status = "Start";

                timer1.Stop();
            }

        }
    }
}
