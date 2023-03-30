using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarieSelbyProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "admin" && pass.Text == "admin")
            {
                MainScreen.admin = true;
                this.Close();
                Form admin = new AdminScreen();
                MainScreen.ActiveForm.Hide();
                admin.Show();

                return;
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
