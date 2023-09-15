using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlserver.Core
{
    public class User : IUser
    {
        public Guid id { get; set; }
        public string FullName { get; set; }
        public string CardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Amount { get; set; }
        public string Password { get; set; }
        public string Currency { get; set; }
        public int Cashback { get; set; }
        //double IUser.Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public User(string phoneNumber)
        {
            PhoneNumber = phoneNumber;    
        }

        public override string ToString()
        {
            return $"{id}#{FullName}#{CardNumber}#{PhoneNumber}#{Amount}#{Password}#{Currency}#{Cashback}";
        }

    }
}
