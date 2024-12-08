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
    public partial class Form2 : Form
    { 
        int s, m, h;
        int t1 = 0;
        int t2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s >= 0)
            {

                s--;
                if (s == 01)
                {
                    t1 = s;
                }


                richours.Text = $"{h.ToString("00")}";
                richmin.Text = $"{m.ToString("00")}";
                richsec.Text = $"{s.ToString("00")}";
            }
            if (s == -1)
            {
                s = 0;
                richours.Text = $"{h.ToString("00")}";
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
                                    richours.Text = $"{h.ToString("00")}";
                                    richmin.Text = $"{m.ToString("00")}";
                                    richsec.Text = $"{s.ToString("00")}";
                                    timer1.Stop();


                                }

                            }
                        }

                    }
                    m--;
                    s = 60;

                    timer1.Start();
                    richours.Text = $"{h.ToString("00")}";
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
                        richours.Text = $"{h.ToString("00")}";
                        richmin.Text = $"{m.ToString("00")}";
                        richsec.Text = $"{s.ToString("00")}";
                       


                    }
                }
             //   timer1.Stop();

                if (h == 0 && m == 0 && s == 0)
                {
                    if (BtnStart.Text == "Start")
                    {
                        BtnStart.Text = "Pause";

                        timer1.Start();
                    }
                    else
                    {
                        BtnStart.Text = "Start";

                        timer1.Stop();
                        System.Media.SoundPlayer p2 = new System.Media.SoundPlayer(Properties.Resources._02);
                        p2.Play();
                        this.Close();
                    }

                }
             //   timer1.Stop();
               

                richsec.ReadOnly = false;
                richmin.ReadOnly = false;
                richours.ReadOnly = false;
                BtnStart.Focus();
             
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            richours.Visible = false;

            s = 0;
            m = 5;
            h = 0;


            timer1.Start();
            BtnStart.Text = "Pause";
            System.Media.SoundPlayer p1 = new System.Media.SoundPlayer(Properties.Resources._02);
            p1.Play();

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {

            richours.Text = $"{h.ToString("00")}";
            richmin.Text = $"{m.ToString("00")}";
            richsec.Text = $"{s.ToString("00")}";
           
            if (BtnStart.Text == "Start")
            {

                BtnStart.Text = "Pause";
                timer1.Start();
            }
            else
            {
                BtnStart.Text = "Start";

                timer1.Stop();
            }

        }
    }
}
