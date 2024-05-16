using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.Json;


namespace GWT
{
    public partial class signUpForm : Form
    {
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        private LandingForm landing = new LandingForm();
       
        public signUpForm()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection poppinsBold = new PrivateFontCollection();
            PrivateFontCollection poppinsReg = new PrivateFontCollection();
            PrivateFontCollection poppinsSemiBold = new PrivateFontCollection();
            poppinsBold.AddFontFile("Resources/Poppins-Bold.ttf");
            poppinsReg.AddFontFile("Resources/Poppins-Regular.ttf");
            poppinsSemiBold.AddFontFile("Resources/Poppins-SemiBold.ttf");

            Control[] labels = { UserLbl, passLbl, ConLbl };
            Control[] links = { skipLink, loginLink };
            Control[] centerCont = { Header, userTxt, passTxt, ConPassTxt, loginLink, SignUpBtn };
            Control[] eyes = { passEye, conEye };

            foreach (Control link in links)
            {
                link.Font = new Font(poppinsBold.Families[0], 8, FontStyle.Bold);
            }
            Header.Font = new Font(poppinsBold.Families[0], 17, FontStyle.Bold);
            foreach (Control cont in centerCont)
            {
                int x = (this.ClientSize.Width - cont.Width) / 2;
                int y = cont.Location.Y;
                cont.Location = new Point(x, y);
            }
            foreach (Control lbl in labels)
            {
                lbl.Font = new Font(poppinsBold.Families[0], 8, FontStyle.Bold);
                int x = userTxt.Location.X;
                int y = lbl.Location.Y;
                lbl.Location = new Point(x, y);
            }
            
            foreach (Control eye in eyes)
            {
                int x = userTxt.Location.X + userTxt.Width;
                int y = eye.Location.Y;
                eye.Location = new Point(x, y);
            }
            loading.BackColor = Color.FromArgb(100, 85, 44, 87);
            loading.Location = new Point(0, 0);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passEye_CheckedChanged(object sender, EventArgs e)
        {
            if (passEye.Checked)
            {
                passTxt.PasswordChar = '\0';
            }
            else
            {
                passTxt.PasswordChar = '•';
            }
        }

        private void conEye_CheckedChanged(object sender, EventArgs e)
        {
            if (conEye.Checked)
            {
                ConPassTxt.PasswordChar = '\0';
            }
            else
            {
                ConPassTxt.PasswordChar = '•';
            }
        }

        private void skipLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            landing.trainingForm.username = "ME";
            landing.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            
            string user = userTxt.Text.Trim();
            string pass = passTxt.Text.Trim();

            if (string.IsNullOrEmpty(userTxt.Text) || string.IsNullOrEmpty(passTxt.Text) || string.IsNullOrEmpty(ConPassTxt.Text))
            {
                MessageBox.Show("All fields should be filled");
            }
            else if (pass != ConPassTxt.Text.Trim()) {
                MessageBox.Show("Passwords Doesn't match");
            }
            else
            {
                try
                {
                    Stacks status = new Stacks();
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();

                    string qry = "INSERT INTO `users`(`id`, `username`, `password`) VALUES (?, ?, ?)";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("param1", null);
                    cmd.Parameters.AddWithValue("param2", user);
                    cmd.Parameters.AddWithValue("param3", pass);

                    cmd.ExecuteNonQuery();

                    landing.trainingForm.username = user;
                    landing.trainingForm.isLoggedIn = true;
                    timer.Start();
                    loading.Visible = true;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
          
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loading.Visible = false;
            this.Hide();
            landing.Show();
            timer.Stop();
        }
    }
}
