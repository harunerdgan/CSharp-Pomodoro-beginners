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

namespace ponodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dakika = 0;
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDakika.Text = Dakika.ToString();
            lblSaniye.Text = saniye.ToString();
            if (saniye==0)
            {
                Dakika--; 
            }
            if (saniye==0)
            {
                saniye = 59;
            }
            saniye--;
            if (Dakika==0)
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                btnKisa.Enabled = true;
                btnYarım.Enabled = true;
                btnUzun.Enabled = true;
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\harun\source\repos\ponodoro\ponodoro\ses.wav";
                ses.Play();
                MessageBox.Show("Alarmm mola zamanı");
                ses.Stop();


            }
            if (Dakika<10)
            {
                lblDakika.Text = "0" + Dakika.ToString();
            }
            if (saniye<10)
            {
                lblSaniye.Text = "0" + saniye.ToString(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnKisa.Enabled = false;
            btnUzun.Enabled = false;
            btnYarım.Enabled = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

            btnBasla.Enabled = false;
            //SoundPlayer ses = new SoundPlayer();
            //string dizin = Application.StartupPath + "\\ses";
            //ses.SoundLocation = dizin;
            //ses.Play();
        }

        private void btnUzun_Click(object sender, EventArgs e)
        {
            renkler3();
            Dakika = 24;
            saniye = 59;
           
            btnBasla.Enabled = true;

        }

        private void renkler3()
        {
            this.BackColor = Color.IndianRed;
            btnKisa.ForeColor = Color.IndianRed;
            btnUzun.ForeColor = Color.IndianRed;
            btnYarım.ForeColor = Color.IndianRed;
            btnBasla.ForeColor = Color.IndianRed;
            btnDurdur.ForeColor = Color.IndianRed;
            panel1.BackColor = Color.LightCoral;
        }

        private void btnKisa_Click(object sender, EventArgs e)
        {
            Renkler1();
            Dakika = 4;
            saniye = 59;
            
            btnBasla.Enabled = true;


        }

        private void Renkler1()
        {
            this.BackColor = Color.LightSeaGreen;
            btnKisa.ForeColor = Color.MediumTurquoise;
            btnUzun.ForeColor = Color.MediumTurquoise;
            btnYarım.ForeColor = Color.MediumTurquoise;
            btnBasla.ForeColor = Color.MediumTurquoise;
            btnDurdur.ForeColor = Color.MediumTurquoise;
            panel1.BackColor = Color.MediumTurquoise;
        }

        private void btnYarım_Click(object sender, EventArgs e)
        {
            renk2();
            
            Dakika = 19;
            saniye = 59;

            
            btnBasla.Enabled = true;



        }

        private void renk2()
        {
            this.BackColor = Color.SteelBlue;
            btnKisa.ForeColor = Color.SteelBlue;
            btnUzun.ForeColor = Color.SteelBlue;
            btnYarım.ForeColor =Color.SteelBlue;
            btnBasla.ForeColor =Color.SteelBlue;
            btnDurdur.ForeColor =Color.SteelBlue;
            panel1.BackColor = Color.CornflowerBlue;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnKisa.Enabled = true;
            btnYarım.Enabled = true;
            btnUzun.Enabled = true;
            
        }
    }
}
