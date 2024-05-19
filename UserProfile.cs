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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void heightTxt_TextChanged(object sender, EventArgs e)
        {

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

            if (e.KeyChar == '.' && !heightTxt.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && heightTxt.SelectionStart == 0 && !heightTxt.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
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

            if (e.KeyChar == '.' && !weightTxt.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && weightTxt.SelectionStart == 0 && !weightTxt.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
