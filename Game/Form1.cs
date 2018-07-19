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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            Bitmap bit = new Bitmap("background.jpg");
            pictureBox1.Image = bit;
            Bitmap bmp = new Bitmap("ghost_rider_wip_by_uncannyknack-dak4xr2 (1).jpg");
            this.button1.BackgroundImage = bmp;
            this.button2.BackgroundImage = bmp;

            this.Text = "Game";
            this.button1.Text = "START";
            this.button2.Text = "EXIT";
            
            this.CancelButton = this.button2;
            this.AcceptButton = this.button1;

            this.button1.FlatStyle = FlatStyle.Popup;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.button1.ForeColor = Color.DarkGray;
            this.button2.ForeColor = Color.DarkGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            
            this.Hide();

        }
       
    }
}
