using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        //public int a;
        public Form2()
        {
            InitializeComponent();
            //timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Cursor = Cursors.Hand;
            this.button1.Text= "OPEN GAMES";
            this.button1.ForeColor = Color.DarkSlateGray;

            Bitmap bmp = new Bitmap("63560634-battlefield-wallpapers.jpg");
            this.pictureBox1.Image = bmp;
            Bitmap bip = new Bitmap("blus-30377-game-ss-9.jpg");
            this.button1.BackgroundImage = bip;

            //button1.Visible = false;
            player.URL = "Call of Duty Modern Warfare 2 Reveal Trailer - Full Version.mp4";
           // axWindowsMediaPlayer1.URL = player.URL;
            player.controls.play();
       //     player.controls.stop();

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            player.controls.stop();
        }

           }

       
    }

