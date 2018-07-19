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
    public partial class Form6 : Form
    {
        
        int count = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Welcome The Tic Tac Toc";
            this.button10.Text = "New Game";
            
            this.button12.Text = "Exit";
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";

            

            
            Bitmap bip = new Bitmap("images.jpg");
            this.button1.BackgroundImage = bip;
            this.button2.BackgroundImage = bip;
            this.button3.BackgroundImage = bip;
            this.button4.BackgroundImage = bip;
            this.button5.BackgroundImage = bip;
            this.button6.BackgroundImage = bip;
            this.button7.BackgroundImage = bip;
            this.button8.BackgroundImage = bip;
            this.button9.BackgroundImage = bip;
            this.button10.BackgroundImage = bip;
       
            this.button12.BackgroundImage = bip;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (count == 0)
            {
                this.button1.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button1.Text = "O";
                count--;
            }

            this.button1.Enabled = false;
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button2.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button2.Text = "O";
                count--;
            }

            this.button2.Enabled = false;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button3.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button3.Text = "O";
                count--;
            }

            this.button3.Enabled = false;
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button4.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button4.Text = "O";
                count--;
            }

            this.button4.Enabled = false;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button5.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button5.Text = "O";
                count--;
            }

            this.button5.Enabled = false;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button6.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button6.Text = "O";
                count--;
            }

            this.button6.Enabled = false;
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button7.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button7.Text = "O";
                count--;
            }

            this.button7.Enabled = false;
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button8.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button8.Text = "O";
                count--;
            }

            this.button8.Enabled = false;
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.button9.Text = "X";
                count++;
            }
            else if (count == 1)
            {
                this.button9.Text = "O";
                count--;
            }

            this.button9.Enabled = false;
            check();
        }
            
        public void check()
        {

            if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                MessageBox.Show("Game Tie");
            }

            
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button3.Text == "X" && this.button5.Text == "X" && this.button7.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            
            if (this.button1.Text == "X" && this.button2.Text == "X" && this.button3.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button4.Text == "X" && this.button5.Text == "X" && this.button6.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button7.Text == "X" && this.button8.Text == "X" && this.button9.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }

            if (this.button1.Text == "X" && this.button4.Text == "X" && this.button7.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button2.Text == "X" && this.button5.Text == "X" && this.button8.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button3.Text == "X" && this.button6.Text == "X" && this.button9.Text == "X")
            {
                MessageBox.Show("You Are Win");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }


            if (this.button1.Text == "O" && this.button5.Text == "O" && this.button9.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button3.Text == "O" && this.button5.Text == "O" && this.button7.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }

            if (this.button1.Text == "O" && this.button2.Text == "O" && this.button3.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button4.Text == "O" && this.button5.Text == "O" && this.button6.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button7.Text == "O" && this.button8.Text == "O" && this.button9.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }

            if (this.button1.Text == "O" && this.button4.Text == "O" && this.button7.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button2.Text == "O" && this.button5.Text == "O" && this.button8.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }
            if (this.button3.Text == "O" && this.button6.Text == "O" && this.button9.Text == "O")
            {
                MessageBox.Show("You Are lose");
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.button1.Text = "";
            this.button1.Enabled = true;
            this.button2.Text = "";
            this.button2.Enabled = true;
            this.button3.Text = "";
            this.button3.Enabled = true;
            this.button4.Text = "";
            this.button4.Enabled = true;
            this.button5.Text = "";
            this.button5.Enabled = true;
            this.button6.Text = "";
            this.button6.Enabled = true;
            this.button7.Text = "";
            this.button7.Enabled = true;
            this.button8.Text = "";
            this.button8.Enabled = true;
            this.button9.Text = "";
            this.button9.Enabled = true;

            count = 0;
        }
    }
}
