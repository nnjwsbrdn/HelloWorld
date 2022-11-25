using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HelloLabel.Text == "Hello" )
            {
                HelloLabel.Text = "Salam";
            }
            else if (HelloLabel.Text == "Salam")
                        {
                HelloLabel.Text = "Kabare";
            }
            else 
            {
                HelloLabel.Text = "Hello";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
