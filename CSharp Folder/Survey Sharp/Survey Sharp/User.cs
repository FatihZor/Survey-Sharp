using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_Sharp
{
    class User
    {
        private string user, pass;

       public User (string un, string ps)
        {
            user = un;
            pass = ps;
        }

        DataConnection dc = new DataConnection();

        public bool validate_login()
        {
            if (dc.validate_login(user, pass) == true)
            {
                return true;
            }
            else
                return false;
        }
      

    }
}
