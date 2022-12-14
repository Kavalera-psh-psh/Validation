using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TunNikMethodInClass
{
    class InValid
    {
        public bool Validation(string Name, string Log, string Pass, string ContPass, string Email, string ContEmail)
        {
            bool result = true;
            if (Name == "")
            {
                result = false;
            }
            if (Log == "")
            {
                result = false;
            }
            if (Pass == "")
            {
                result = false;
            }
            if (ContPass == "")
            {
                result = false;
            }
            if (Email == "")
            {
                result = false;
            }
            if (ContEmail == "")
            {
                result = false;
            }
            if (Name != "" && Log != "" && Pass != "" && ContPass != "" && Email != "" && ContEmail != "")
            {
                result = true;
            }
            return result;
        }
    }
}
