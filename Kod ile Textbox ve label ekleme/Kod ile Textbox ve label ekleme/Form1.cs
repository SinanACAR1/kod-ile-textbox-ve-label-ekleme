using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textbox1 = new TextBox();
            textbox1.Top = 50;
            textbox1.Left = 30;
            textbox1.Width = 100;
            textbox1.Text = "";

            this.Controls.Add(textbox1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 75;
            textbox.Left = 30;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 100;
            textbox.Left = 30;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 125;
            textbox.Left = 30;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 50;
            textbox.Left = 170;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 75;
            textbox.Left = 170;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 100;
            textbox.Left = 170;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Top = 125;
            textbox.Left = 170;
            textbox.Width = 100;
            textbox.Text = "";

            this.Controls.Add(textbox);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Top = 10;
            label.Left = 114;
            label.Width = 123;
            label.Text = "Sinan Acar";

            this.Controls.Add(label);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kodla textbox ve label koyma.";
               
        }
    }
}
