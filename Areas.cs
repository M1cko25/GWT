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
    public partial class Areas : Form
    {
        private BMI bmiForm = new BMI();

        public Areas()
        {
            InitializeComponent();
        }
        
        private void Areas_Load(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            btntoggle(backBtn);
        }

        private void shouderBtn_Click(object sender, EventArgs e)
        {
            btntoggle(shouderBtn);
        }
        private void btntoggle(Guna.UI2.WinForms.Guna2Button btn)
        {
            Color checkedColor = Color.FromArgb(255, 226, 105, 114);
            Color uncheckedColor = Color.FromArgb(255, 85, 44, 87);
            if (btn.FillColor == uncheckedColor)
            {
                btn.FillColor = checkedColor;
            }
            else
            {
                btn.FillColor = uncheckedColor;
                fullBodyBtn.FillColor = uncheckedColor;
            }
            isAllBtnChecked(btn);
        }

        private void armBtn_Click(object sender, EventArgs e)
        {
            btntoggle(armBtn);
        }

        private void chestBtn_Click(object sender, EventArgs e)
        {
            btntoggle(chestBtn);
        }

        private void absBtn_Click(object sender, EventArgs e)
        {
            btntoggle(absBtn);
        }

        private void buttBtn_Click(object sender, EventArgs e)
        {
            btntoggle(buttBtn);
        }

        private void legBtn_Click(object sender, EventArgs e)
        {
            btntoggle(legBtn);
        }

        private void fullBodyBtn_Click(object sender, EventArgs e)
        {
            Color checkedColor = Color.FromArgb(255, 226, 105, 114);
            Color uncheckedColor = Color.FromArgb(255, 85, 44, 87);
            Guna.UI2.WinForms.Guna2Button[] btns = { backBtn,shouderBtn,chestBtn,absBtn, armBtn, buttBtn, legBtn };
            
            if (fullBodyBtn.FillColor == uncheckedColor)
            {
                fullBodyBtn.FillColor = checkedColor;
                foreach (Guna.UI2.WinForms.Guna2Button button in btns)
                {
                    button.FillColor = checkedColor;
                }
            }
            else
            {
                fullBodyBtn.FillColor = uncheckedColor;
                foreach (Guna.UI2.WinForms.Guna2Button button in btns)
                {
                    button.FillColor = uncheckedColor;
                }
            }
        }

        private void isAllBtnChecked(Guna.UI2.WinForms.Guna2Button button)
        {
            Color checkedColor = Color.FromArgb(255, 226, 105, 114);
            Color uncheckedColor = Color.FromArgb(255, 85, 44, 87);
            
            Guna.UI2.WinForms.Guna2Button[] btns = { backBtn, shouderBtn, chestBtn, absBtn, armBtn, buttBtn, legBtn };
            if (button.FillColor == checkedColor && (backBtn.FillColor == checkedColor && shouderBtn.FillColor == checkedColor
                && armBtn.FillColor == checkedColor && chestBtn.FillColor == checkedColor && absBtn.FillColor == checkedColor 
                && buttBtn.FillColor == checkedColor && legBtn.FillColor == checkedColor))
            {
                fullBodyBtn.FillColor = checkedColor;
            } else
            {
                fullBodyBtn.FillColor = uncheckedColor;
            }
        }

        private void AreasContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
