using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private LandingForm landing = new LandingForm();
        public Login()
        {
            InitializeComponent();
        }

        private void Header_Click(object sender, EventArgs e)
        {

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
            Control[] centerCont = { Header, userTxt, passTxt, forgotpass, signUpLink, loginBtn };
            

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

            }
        }
    }
}
