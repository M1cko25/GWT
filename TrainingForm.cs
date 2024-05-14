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
    public partial class TrainingForm : Form
    {
        public TrainingForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            NavPanel.BackColor = Color.FromArgb(127, 85, 44, 87);
        }
    }
}
