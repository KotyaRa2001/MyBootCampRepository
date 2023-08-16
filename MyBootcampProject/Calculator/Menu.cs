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
    public partial class Menu : Form
    {
        const string OurPassword = "12345";
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            enterPasword:
            string password = Password.Show();
            if(password == "")
            {
                this.Close();
            }
            if(password != OurPassword && password != "")
            {
                MessageBox.Show("Попробуйте еще раз!", "Пароль неверный",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                goto enterPasword;
            }
        }

        private void lblLinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Calculator();
            frm.Show();
        }
    }
}
