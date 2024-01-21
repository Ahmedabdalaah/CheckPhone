using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckPhone
{
    internal class CheckP
    {
        public bool check(string number)
        {
            Regex re = new Regex("\\d");
            if (re.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool checkL(string number)
        {
            if (number.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
