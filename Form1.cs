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
    public partial class Form1 : Form
    {
        int s, m, h, count;
        int t1 = 0;
        int t2 = 0;
        System.Media.SoundPlayer p1 = new System.Media.SoundPlayer(Properties.Resources._02);
        System.Media.SoundPlayer p2 = new System.Media.SoundPlayer(Properties.Resources._02);


        private void BtnStart_Click(object sender, EventArgs e)
        {
            count = int.Parse(CountNumtext.Text);
            CountNumtext.Enabled = false;

            s = 0;
            m = 25;
            h = 0;
            timer1.Start();
            btnstart2.Text = "Pause";
            System.Media.SoundPlayer p1 = new System.Media.SoundPlayer(Properties.Resources._02);
            p1.Play();

            Btnstart.Visible = false;
            btnstart2.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            richours.Visible = false;
            btnstart2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void BtnStop_Click_1(object sender, EventArgs e)
        {
            btnstart2.Text = "Start";

            timer1.Stop();
        }

        private void btnstart2_Click(object sender, EventArgs e)
        {
            if (btnstart2.Text == "Start")
            {

                btnstart2.Text = "Pause";
                timer1.Start();
            }
            else
            {
                btnstart2.Text = "Start";

                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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


                }
            }
            if (s <= 0)
            {
                if (m > 0)
                {
                    if (m == 0)
                    {
                        if (h >= 0)
                        {
                            h--;
                            m = 60;
                            if (h < 0)
                            {


                                if (m == 0 && s == 0)
                                {

                                    richmin.Text = $"{m.ToString("00")}";
                                    richsec.Text = $"{s.ToString("00")}";
                                    timer1.Stop();
                                    count--;
                                    CountNumtext.Text = count.ToString();
                                    Form2 f2 = new Form2();
                                    f2.ShowDialog();
                                    timer1 = new Timer();
                                    timer1.Interval = 1000;
                                    timer1.Start();
                                    if (count == 0)
                                    {
                                        timer1.Enabled = false;
                                        MessageBox.Show("Wel Done");


                                    }


                                }

                            }
                        }

                    }
                    m--;
                    s = 60;
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
                    if (m == 0 && s == 0)
                    {
                        timer1.Stop();

                        richmin.Text = $"{m.ToString("00")}";
                        richsec.Text = $"{s.ToString("00")}";
                    }
                }
                if (m == 0 && s == 0)
                {
                    if (btnstart2.Text == "Start")
                    {
                        btnstart2.Text = "Pause";

                        timer1.Start();
                    }
                    else
                    {
                        btnstart2.Text = "Start";

                        timer1.Stop();

                        p2.Play();
                    }
                }
                if (h == 0 && m == 0 && s == 0)
                {
                    p1.Play();
                    timer1.Stop();
                    count--;
                    CountNumtext.Text = count.ToString();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    timer1 = new Timer();
                    timer1.Interval = 1000;

                    if (count != 0)
                    {
                        s = 0;
                        m = 25;
                        h = 0;
                        timer1.Start();
                        timer1.Tick += new EventHandler(timer1_Tick);
                    }
                    else
                    {
                        timer1.Enabled = false;
                        System.Media.SoundPlayer play = new System.Media.SoundPlayer(Properties.Resources.generic_alarm_clock_86759);
                        play.Play();
                        DialogResult dt= MessageBox.Show("Wel Done","",MessageBoxButtons.OK);
                        if (dt==DialogResult.OK)
                        {
                            Application.Restart();
                        }
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnStop_Click(object sender, EventArgs e)
        {

        }



    }
}
