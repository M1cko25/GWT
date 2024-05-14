using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWT
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            BmiPanel.FillColor = Color.FromArgb(153, 255, 255, 255);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(BmiContent);
        }

        private void ftBtn_Click(object sender, EventArgs e)
        {
            measureToggle(ftBtn, cmBtn);
        }

        private void cmBtn_Click(object sender, EventArgs e)
        {
            measureToggle(cmBtn, ftBtn);
        }

        private void kgBtn_Click(object sender, EventArgs e)
        {
            measureToggle(kgBtn, lbsBtn);
        }

        private void lbsBtn_Click(object sender, EventArgs e)
        {
            measureToggle(lbsBtn, kgBtn);
        }

        private void measureToggle(Guna.UI2.WinForms.Guna2Button cont1, Guna.UI2.WinForms.Guna2Button cont2)
        {
            cont1.BringToFront();
            cont1.FillColor = Color.FromArgb(255, 226, 105, 114);
            cont1.BorderThickness = 1;
            cont2.SendToBack();
            cont2.FillColor = Color.FromArgb(255, 85, 44, 87);
            cont2.BorderThickness = 0;
        }

        private void heightTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !heightTxt.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && heightTxt.SelectionStart == 0 && !heightTxt.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
        }

        private void weightTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !weightTxt.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && weightTxt.SelectionStart == 0 && !weightTxt.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
