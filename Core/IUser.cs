using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlserver.Core
{
    public interface IUser
    {
        Guid id { get; set; }
        string FullName { get; set; }
        string CardNumber { get; set; }
        string PhoneNumber { get; set; }
        int Amount { get; set; }
        string Password { get; set; }
    }
}