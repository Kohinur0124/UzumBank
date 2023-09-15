using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlserver.Core
{
    public class Report
    {
        public Guid id { get; set; }
        public string SenderCardNumber { get; set; }
        public string RecipientCard { get; set; }
        public int Payment { get ; set; }

        public Report() { }
        public Report(Guid i,string scard,string rcard,int pay)
        {
            id = i;
            SenderCardNumber = scard;
            RecipientCard = rcard;
            Payment = pay;
            
        }
        public override string ToString()
        {
            return $"{id}#{SenderCardNumber}#{RecipientCard}#{Payment}";
        }

    } 
}
