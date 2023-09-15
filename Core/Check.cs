using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sqlserver.Core
{
    public static class Check
    {
        public static bool CheckedPhoneNumber(string phoneNumber)
        {

            if (phoneNumber.Contains("+998") && phoneNumber.Length ==13)
            {
                return true;
            }
            return false;
        }
        public static bool CheckedPassword(string  password)
        {
            if (password.Length >7 &&  (password.Any(char.IsNumber) && password.Any(char.IsLower) && password.Any(char.IsUpper) )) 
            {
                return true;
            }
            return false;
        }

        public static bool Checked(string password,string s) 
        {
            if (password.Equals(s)) 
            {
                return true;
            }
            return false;

        }
        public static bool CheckCardNumber(string cardNumber) 
        {
            if (cardNumber.Length == 16 && cardNumber.All(char.IsNumber))
            {
                return true;

            }
            return false;
        }
             
    }
}
