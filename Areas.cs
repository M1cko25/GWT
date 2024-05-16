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
        public string username, gender;
        public bool back = false, shoulder = false, arm = false, chest = false, abs = false, butt = false, leg = false;
        public Areas()
        {
            InitializeComponent();
        }
        
        private void Areas_Load(object sender, EventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (back == false)
            {
                back = true;
            }
            else
            {
                back = false;
            }
            btntoggle(backBtn);
        }
        private void shouderBtn_Click(object sender, EventArgs e)
        {
            if (shoulder == false)
            {
                shoulder = true;
            }
            else
            {
                shoulder = false;
            }
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
            if (arm == false)
            {
                arm = true;
            }
            else
            {
                arm = false;
            }
            btntoggle(armBtn);
        }

        private void chestBtn_Click(object sender, EventArgs e)
        {
            if (chest == false)
            {
                chest = true;
            }
            else
            {
                chest = false;
            }
            btntoggle(chestBtn);
        }

        private void absBtn_Click(object sender, EventArgs e)
        {
            if (abs == false)
            {
                abs = true;
            }
            else
            {
                abs = false;
            }
            btntoggle(absBtn);
        }

        private void buttBtn_Click(object sender, EventArgs e)
        {
            if (butt == false)
            {
                butt = true;
            }
            else
            {
                butt = false;
            }
            btntoggle(buttBtn);
        }

        private void legBtn_Click(object sender, EventArgs e)
        {
            if (leg == false)
            {
                leg = true;
            } else
            {
                leg = false;
            }
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
                for (int i = 0; i < btns.Length; i++)
                {
                    btns[i].FillColor = checkedColor;
                    back = true;
                    shoulder = true;
                    arm = true;
                    chest = true;
                    abs = true;
                    butt = true;
                    leg = true;
                }
            }
            else
            {
                fullBodyBtn.FillColor = uncheckedColor;
                for (int i = 0; i < btns.Length; i++)
                {
                    btns[i].FillColor = uncheckedColor;
                    back = false;
                    shoulder = false;
                    arm = false;
                    chest = false;
                    abs = false;
                    butt = false;
                    leg = false;
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
    }
}
