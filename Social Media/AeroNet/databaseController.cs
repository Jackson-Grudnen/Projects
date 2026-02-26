using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroNet
{
    internal class databaseController
    {
        private databaseConnection myConnection_;
        public databaseController()
        {
            myConnection_ = new databaseConnection();

        }
        public bool getLogin(string Username, string Password)
        {
            return myConnection_.login(Username, Password);
        }
    }
}
