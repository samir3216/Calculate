using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
namespace calculate
{
    public partial class Form1 : Form
    {

        decimal ram = 0.00m; // Floats only d 0.00
        string mode = "";
        bool dotlocated = false;



        protected override void OnHandleCreated(EventArgs e)
        {

        }


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        // BUTTON INDEX

        // Percent - C
        // Square - S
        // Plus - P
        // Minus - M
        // Divide - D
        // X - X
        private void percent_Click(object sender, EventArgs e)
        {
            if(!(display.Text == ""))
            {
                PreviousNumber.Text = display.Text;
                ram = decimal.Parse(display.Text);
                mode = "c";
                display.Text = "";
            }

        }

        private void square_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                PreviousNumber.Text = display.Text;
                display.Text = (Math.Sqrt(int.Parse(display.Text))).ToString();
            }
            
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                PreviousNumber.Text = display.Text;
                ram = decimal.Parse(display.Text);
                mode = "d";
                display.Text = "";
            }

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                PreviousNumber.Text = display.Text;
                ram = decimal.Parse(display.Text);
                mode = "x";
                display.Text = "";
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                PreviousNumber.Text = display.Text;
                ram = decimal.Parse(display.Text);
                mode = "m";
                display.Text = "";
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                PreviousNumber.Text = display.Text;
                ram = decimal.Parse(display.Text);
                mode = "p";
                display.Text = "";
            }

        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (display.Text == "") { return; } // well well well

            if (mode == "p") // plus
            {
                decimal result = decimal.Parse(display.Text) + ram;
                display.Text = result.ToString();;

            }
            if (mode == "m") // minus
            {
                decimal result = decimal.Parse(display.Text) - ram;
                display.Text = result.ToString();
            }
            if (mode == "x") // multiply
            {
                decimal result = decimal.Parse(display.Text) * ram;
                display.Text = result.ToString();
            }
            if (mode == "d") // divide
            {
                if(display.Text == "0" || ram == 0) // used to catch some type of people..
                {
                    display.Text = "E";
                }
                else
                {
                    decimal result = decimal.Parse(display.Text) / ram;
                    display.Text = result.ToString();
                }

            }
            if (mode == "c") // percent
            {
                decimal result = decimal.Parse(display.Text) * ram / 100;
                display.Text = result.ToString();
            }
            
        }



        private void zero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            PreviousNumber.Text = "";
            display.Text = "";
            ram = 0;
            mode = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            display.Text += ",";
        }
    }
}
