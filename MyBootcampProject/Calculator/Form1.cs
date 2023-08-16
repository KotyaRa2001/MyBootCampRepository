using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            lblName3.Text = counter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName1.Text = "Hello world!";

        }

        private void btnName1_Click(object sender, EventArgs e)
        {
            lblName2.Text = "Semyon";
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            lblName3.Text = counter.ToString();

        }
    }
}
