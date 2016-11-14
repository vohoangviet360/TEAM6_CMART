using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEAM6_CMART
{
    public partial class GUI_MAIN : Form
    {
        private string permission = "director";
        public GUI_MAIN()
        {
            InitializeComponent();
        }

        public void setPermission(string permission)
        {
            this.permission = permission;
        }

        public string getPermission(string permission)
        {
            return this.permission;
        }

        

        private void GUI_MAIN_Load(object sender, EventArgs e)
        {

        }
    }
}
