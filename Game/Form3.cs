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
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
            this.button3.Text = "Tic Tac Toc Game";
            this.label1.Text = "Select The Game";

                       this.button3.FlatStyle = FlatStyle.Popup;
            this.button3.Cursor = Cursors.Hand;
            this.button3.ForeColor = Color.DarkSlateGray;

            

            
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
            
        }


    }
}
