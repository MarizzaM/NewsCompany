using NewsCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller
{
    public class Seller
    {
        private int moneyEarned = 0;

        public void SellNewspaper(Newspaper x) {
            moneyEarned += (int)x.GetPrice();
        }

        public override string ToString()
        {
            return $"Seller had earned {moneyEarned} NIS";
        }
    }
}
