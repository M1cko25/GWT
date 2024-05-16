using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GWT
{
    public partial class LandingForm : Form
    {
        private int yOffset = 20;
        public BMI bmiForm = new BMI();
        public TrainingForm trainingForm = new TrainingForm();
       
        
        public LandingForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection poppinsBold = new PrivateFontCollection();
            PrivateFontCollection poppinsReg = new PrivateFontCollection();
            PrivateFontCollection poppinsSemiBold = new PrivateFontCollection();
            poppinsBold.AddFontFile("Resources/Poppins-Bold.ttf");
            poppinsReg.AddFontFile("Resources/Poppins-Regular.ttf");
            poppinsSemiBold.AddFontFile("Resources/Poppins-SemiBold.ttf");

            maleLbl.Font = new Font(poppinsBold.Families[0], 16, FontStyle.Bold);
            femaleLbl.Font = new Font(poppinsBold.Families[0], 16, FontStyle.Bold);
            headerLbl.Font = new Font(poppinsBold.Families[0], 30, FontStyle.Bold);

            loadingScr.Location = new Point(0, 0);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            yOffset = Math.Max(0, yOffset - 2);

            maleBtn.ImageOffset = new Point(0, yOffset);
            femaleBtn.ImageOffset = new Point(0, yOffset);

            if (yOffset == 0)
            {
                timer.Stop();
            }
        }

        private void maleBtn_Click(object sender, EventArgs e)
        {
            trainingForm.gender = "Male";
            Control[] genderCont = { maleBtn, femaleBtn, maleLbl, femaleLbl, headerLbl };
            foreach(Control cont in genderCont)
            {
                mainPanel.Controls.Remove(cont);
                //cont.Dispose();
            }
            
            mainPanel.Controls.Add(trainingForm.areasForm.AreasContent);
            BtnBack.Visible = true;
            BtnNext.Visible = true;
        }

        private void femaleBtn_Click(object sender, EventArgs e)
        {
            trainingForm.gender = "Female";
            Control[] genderCont = { maleBtn, femaleBtn, maleLbl, femaleLbl, headerLbl };
            foreach (Control cont in genderCont)
            {
                mainPanel.Controls.Remove(cont);
                //cont.Dispose();
            }

            mainPanel.Controls.Add(trainingForm.areasForm.AreasContent);
            BtnBack.Visible = true;
            BtnNext.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(trainingForm.areasForm.AreasContent))
            {
                mainPanel.Controls.Remove(trainingForm.areasForm.AreasContent);
                //areasForm.AreasContent.Dispose();
                Control[] genderCont = { maleBtn, femaleBtn, maleLbl, femaleLbl, headerLbl };
                foreach (Control cont in genderCont)
                {
                    mainPanel.Controls.Add(cont);
                }
                BtnBack.Visible = false;
                BtnNext.Visible = false;
            } else if (mainPanel.Controls.Contains(bmiForm.BmiContent))
            {
                mainPanel.Controls.Remove(bmiForm.BmiContent);
                //bmiForm.BmiContent.Dispose();
                mainPanel.Controls.Add(trainingForm.areasForm.AreasContent);
            }
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(trainingForm.areasForm.AreasContent))
            {
                if (trainingForm.areasForm.back == false && trainingForm.areasForm.arm == false && trainingForm.areasForm.shoulder == false && trainingForm.areasForm.chest == false && trainingForm.areasForm.abs == false && trainingForm.areasForm.butt == false && trainingForm.areasForm.leg == false)
                {
                    MessageBox.Show("Please Select An Muscle Area");
                }
                else
                {
                    mainPanel.Controls.Remove(trainingForm.areasForm.AreasContent);
                    //areasForm.AreasContent.Dispose();
                    mainPanel.Controls.Add(bmiForm.BmiContent);
                    bmiForm.BmiPanel.FillColor = Color.FromArgb(153, 255, 255, 255);
                }
            }
            else {
                
                timer1.Start();
                loadingScr.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingScr.Visible = false;
            this.Hide();
            trainingForm.Show();
            timer1.Stop();
        }
    }
}
