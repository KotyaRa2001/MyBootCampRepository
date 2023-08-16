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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            this.ActiveControl = txtBoxPassword;
        }
        public static string Show()
        {
            using (Password inputDlg = new Password())
            {
                inputDlg.ShowDialog();
                return inputDlg.txtBoxPassword.Text;
            }
        }
    }
}
