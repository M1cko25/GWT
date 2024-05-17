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
        private Guna.UI2.WinForms.Guna2Button selectedButton = null;

        public BMI()
        {
            InitializeComponent();
            
           

            // Optionally select the default button
            SelectButton(btnKg);
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
            measureToggle(btnFt, btnM);
        }

        private void cmBtn_Click(object sender, EventArgs e)
        {
            measureToggle(btnM, btnFt);
        }

        private void kgBtn_Click(object sender, EventArgs e)
        {
            measureToggle(btnKg, btnLb);
        }

        private void lbsBtn_Click(object sender, EventArgs e)
        {
            measureToggle(btnLb, btnKg);
        }

        private void measureToggle(Guna.UI2.WinForms.Guna2Button cont1, Guna.UI2.WinForms.Guna2Button cont2)
        {
            // Reset the appearance of both buttons
            btnKg.FillColor = Color.Transparent;
            btnKg.BorderThickness = 0;
            btnLb.FillColor = Color.Transparent;
            btnLb.BorderThickness = 0;

            // Set the new appearance for the clicked button
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

            if (e.KeyChar == '.' && !txtHeight.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && txtHeight.SelectionStart == 0 && !txtHeight.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
            int height = Convert.ToInt32(txtHeight.Text);
            int weight = Convert.ToInt32(txtWeight.Text);
            int bmi = weight / (height * height);
            Bmilabel.Text = Convert.ToString(bmi);
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

            if (e.KeyChar == '.' && !txtWeight.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && txtWeight.SelectionStart == 0 && !txtWeight.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;

            int height = Convert.ToInt32(txtHeight.Text);
            int weight = Convert.ToInt32(txtWeight.Text);
            int bmi = weight / (height * height);
            Bmilabel.Text = Convert.ToString(bmi);
        }

        private void BmiContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKg_Click(object sender, EventArgs e)
        {
            SelectButton(btnKg);
        }

        private void btnLb_Click(object sender, EventArgs e)
        {
            SelectButton(btnLb);
        }

        private void SelectButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            if (selectedButton != null)
            {
                // Reset the previously selected button's appearance
                selectedButton.FillColor = Color.Transparent;
                selectedButton.BorderThickness = 0;
            }

            // Set the new selected button's appearance
            btn.FillColor = Color.LightBlue;
            btn.BorderThickness = 2;

            // Update the selected button variable
            selectedButton = btn;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(txtWeight.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                double result = 0.0;
                string result2 = "";

                if (selectedButton == btnKg)
                {
                    result = weight / (height * height);
                }
                else if (selectedButton == btnLb)
                {
                    weight = weight / 2.205;
                    result = weight / (height * height);
                }

                if (result < 18.5)
                {
                    result2 = "You are underweight";
                }
                else if (result < 25)
                {
                    result2 = "You have normal weight";
                }
                else if (result < 30)
                {
                    result2 = "You are overweight";
                }
                else if (result >= 30)
                {
                    result2 = "You are obese";
                }

                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for weight and height.");
            }

        }

        private void Commentlabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

            ComputeBmi();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            ComputeBmi();
        }
         
        private void ComputeBmi() { 
            if (double.TryParse(txtWeight.Text, out double weight) && double.TryParse(txtHeight.Text, out double height))
            {
                double bmi = weight / (height * height);
                Bmilabel.Visible = true;
                Commentlabel.Visible = true;
                
                
                 if (bmi < 18.5)
                {
                    Bmilabel.Text = bmi.ToString("#.#");
                    Commentlabel.Text = "Amazing!, Want to be feel stronger?";
                } 
                else if (bmi > 18.5 && bmi < 25)
                {
                    Bmilabel.Text = bmi.ToString("#.#");
                    Commentlabel.Text = "You've Got a great shape!, Keep it Up!";
                } else
                {
                    Bmilabel.Text = bmi.ToString("#.#");
                    Commentlabel.Text = "Marvelous!, Want to lose weight";
                }
            }

        }
    }
}


