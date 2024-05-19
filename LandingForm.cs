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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GWT
{
    public partial class LandingForm : Form
    {
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";

        private int yOffset = 20;
        public BMI bmiForm = new BMI();
        public TrainingForm trainingForm = new TrainingForm();
        public string userPass { get; set; }
       
        
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

            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string qry = "SELECT * FROM `users` WHERE username = @username AND password = @pass";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@username", trainingForm.username);
            cmd.Parameters.AddWithValue("@pass", userPass);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                trainingForm.userId = reader.GetInt32("id");
            }

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
            if (trainingForm.isLoggedIn)
            {
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "UPDATE `users` SET `gender`= @gender WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@gender", trainingForm.gender);
                cmd.Parameters.AddWithValue("@id", trainingForm.userId);
                cmd.ExecuteNonQuery();
                con.Close();
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
            if (trainingForm.isLoggedIn)
            {
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();
                string qry = "UPDATE `users` SET `gender`= @gender WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@gender", trainingForm.gender);
                cmd.Parameters.AddWithValue("@id", trainingForm.userId);
                cmd.ExecuteNonQuery();
                con.Close();
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
                    int back = 0;
                    int shoulder = 0;
                    int arm = 0;
                    int chest = 0;
                    int abs = 0;
                    int butt = 0;
                    int leg = 0;

                    if (trainingForm.areasForm.back)
                    {
                        trainingForm.back = 1;
                        back = 1;
                    }
                    if (trainingForm.areasForm.shoulder)
                    {
                        trainingForm.shoulder = 1;
                        shoulder = 1;
                    }
                    if (trainingForm.areasForm.arm)
                    {
                        trainingForm.arm = 1;
                        arm = 1;
                    }
                    if (trainingForm.areasForm.chest)
                    {
                        trainingForm.chest = 1;
                        chest = 1;
                    }
                    if (trainingForm.areasForm.abs)
                    {
                        trainingForm.abs = 1;
                        abs = 1;
                    }
                    if (trainingForm.areasForm.butt)
                    {
                        trainingForm.butt = 1;
                        butt = 1;
                    }
                    if (trainingForm.areasForm.leg)
                    {
                        trainingForm.leg = 1;
                        leg = 1;
                    }
                    
                    if (trainingForm.isLoggedIn)
                    {
                        MySqlConnection con = new MySqlConnection(connstring);
                        con.Open();
                        string qry = "INSERT INTO `areasfocused`(`userId`, `back`, `shoulder`, `arm`, `chest`, `abs`, `butt`, `leg`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                        MySqlCommand cmd = new MySqlCommand(qry, con);
                        cmd.Parameters.AddWithValue("@param1", trainingForm.userId);
                        cmd.Parameters.AddWithValue("@param2", back);
                        cmd.Parameters.AddWithValue("@param3", shoulder);
                        cmd.Parameters.AddWithValue("@param4", arm);
                        cmd.Parameters.AddWithValue("@param5", chest);
                        cmd.Parameters.AddWithValue("@param6", abs);
                        cmd.Parameters.AddWithValue("@param7", butt);
                        cmd.Parameters.AddWithValue("@param8", leg);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    } 

                    mainPanel.Controls.Remove(trainingForm.areasForm.AreasContent);
                    //areasForm.AreasContent.Dispose();
                    mainPanel.Controls.Add(bmiForm.BmiContent);
                    bmiForm.BmiPanel.FillColor = Color.FromArgb(153, 255, 255, 255);
                }
            }
            else {
                if (bmiForm.heightTxt.Text == "0" || bmiForm.weightTxt.Text == "0")
                {
                    MessageBox.Show("Please provide a height and weight");
                } else
                {
                    trainingForm.bmi = bmiForm.bmi;
                    trainingForm.userHeight = Convert.ToDouble(bmiForm.heightTxt.Text);
                    trainingForm.userWeight = Convert.ToDouble(bmiForm.weightTxt.Text);
                    if (bmiForm.bmi <= 18.5)
                    {
                        trainingForm.bodyType = "Under Weight";
                    } else if (bmiForm.bmi >= 18.6 && bmiForm.bmi <= 25)
                    {
                        trainingForm.bodyType = "Healthy";
                    } else
                    {
                        trainingForm.bodyType = "Over Weight";
                    }

                    if (trainingForm.isLoggedIn)
                    {
                        MySqlConnection con = new MySqlConnection(connstring);
                        con.Open();
                        string qry = "UPDATE `users` SET `height`= @height,`weight`= @weight,`body-type`= @bodyType,`bmi`= @bmi WHERE id = @userId";
                        MySqlCommand cmd = new MySqlCommand(qry, con);
                        cmd.Parameters.AddWithValue("@height", Convert.ToDouble(bmiForm.heightTxt.Text));
                        cmd.Parameters.AddWithValue("@weight", Convert.ToDouble(bmiForm.weightTxt.Text));
                        cmd.Parameters.AddWithValue("@bodyType", trainingForm.bodyType);
                        cmd.Parameters.AddWithValue("@bmi", trainingForm.bmi);
                        cmd.Parameters.AddWithValue("@userId", trainingForm.userId);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    timer1.Start();
                    loadingScr.Visible = true;
                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingScr.Visible = false;
            this.Hide();
            trainingForm.Show();
            timer1.Stop();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
