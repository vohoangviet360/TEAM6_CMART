using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEAM6_CMART.BUS
{
    class BUS_ACCOUNT
    {
        private CMART6Entities db = null;
        public BUS_ACCOUNT()
        {
            db = new CMART6Entities();
        }

        public bool checkLogin(string username, string password)
        {
            ACCOUNT temp;
            try
            {
                temp = db.ACCOUNTs.Single(a => a.username.Equals(username));
            }
            catch
            {
                return false;
            }

            if (temp.password.Equals(password))
                return true;
            else
                return false;
        }
    }
}
