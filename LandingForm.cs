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
using Guna.UI2.WinForms;

namespace GWT
{
    public partial class LandingForm : Form
    {
        private int yOffset = 20;
        private User _user = new User();
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
            headerLbl.Font = new Font(poppinsBold.Families[0], 29, FontStyle.Bold);
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

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maleBtn_Click(object sender, EventArgs e)
        {
            _user.gender = "Male";
        }

        private void femaleBtn_Click(object sender, EventArgs e)
        {
            _user.gender = "Female";
        }
    }
}
