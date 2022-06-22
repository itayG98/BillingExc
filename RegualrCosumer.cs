using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingExc
{
    public class RegualrCosumer : Costumer
    {
        public RegualrCosumer(string name, double balance = 0) : base(name, balance)
        {
        }

        public override void AddedToBalance(double amount)
        {
            Balance += amount;
        }
    }
}
