using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GWT
{
    public partial class Login : Form
    {
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        private signUpForm signUp = new signUpForm();
        private LandingForm landing = new LandingForm();
        public TrainingForm trainingForm = new TrainingForm();
        private Areas areasForm = new Areas();
        public Login()
        {
            InitializeComponent();
        }

        private void Header_Click(object sender, EventArgs e)
        {

        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            PrivateFontCollection poppinsBold = new PrivateFontCollection();
            PrivateFontCollection poppinsReg = new PrivateFontCollection();
            PrivateFontCollection poppinsSemiBold = new PrivateFontCollection();
            poppinsBold.AddFontFile("Resources/Poppins-Bold.ttf");
            poppinsReg.AddFontFile("Resources/Poppins-Regular.ttf");
            poppinsSemiBold.AddFontFile("Resources/Poppins-SemiBold.ttf");

            Control[] labels = { UserLbl, passLbl };
            Control[] links = { skipLink, signUpLink };
            Control[] centerCont = { Header, userTxt, passTxt, signUpLink, loginBtn };
            

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

            int x1 = userTxt.Location.X + userTxt.Width;
            int y1 = passEye.Location.Y;
            passEye.Location = new Point(x1, y1);
            loading.BackColor = Color.FromArgb(100, 85, 44, 87);
            loading.Location = new Point(0, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string user = userTxt.Text.Trim();
            string pass = passTxt.Text.Trim();

            if (string.IsNullOrEmpty(userTxt.Text) || string.IsNullOrEmpty(passTxt.Text))
            {
                MessageBox.Show("All fields should be filled");
            } 
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connstring);
                    conn.Open();

                    string qry = "SELECT `username`, `password` FROM `users` WHERE username = @username and password = @pass";
                    MySqlCommand cmd = new MySqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@pass", HashPassword(pass));
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {


                        trainingForm.username = user;
                        trainingForm.isLoggedIn = true;
                        timer.Start();
                        loading.Visible = true;
                    } else
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                } catch (MySqlException ex)
                {
                    
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Contact administrator.");
                            break;
                        case 1042:
                            MessageBox.Show("Can't connect To server");
                            break;
                        default:
                            MessageBox.Show($"MySQL error number: {ex.Number}. Message: {ex.Message}");
                            break;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loading.Visible = false;
            this.Hide();
            trainingForm.Show();
            timer.Stop();
        }

        private void passEye_CheckedChanged(object sender, EventArgs e)
        {
            if (passEye.Checked)
            {
                passTxt.PasswordChar = '\0';
            } else
            {
                passTxt.PasswordChar = '•';
            }
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signUp.Show();
        }

        private void skipLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            landing.trainingForm.username = "ME";
            this.Hide();
            landing.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
