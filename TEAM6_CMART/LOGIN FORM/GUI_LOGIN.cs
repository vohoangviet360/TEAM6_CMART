using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEAM6_CMART.BUS;

namespace TEAM6_CMART.Manage_Accounts
{
    public partial class GUI_LOGIN : Form
    {
        public GUI_LOGIN()
        {
            InitializeComponent();
        }

        private void GUI_LOGIN_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPassword.Text;
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BUS_ACCOUNT bus_account = new BUS_ACCOUNT();
                bool check = bus_account.checkLogin(username, password);
                if (check == true)
                {
                    GUI_MAIN f = new GUI_MAIN();
                    
                    f.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
