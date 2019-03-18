using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TheDebtBook.Model
{
    class Debts
    {
        public String Name { get; set; }
        public double Sum { get; set; }
        public List<double> Amounts;

        public Debts(string name, double currentAmount)
        {
            Name = name;
            Amounts.Add(currentAmount);
            CalculateSum(Amounts);
        }

        public double CalculateSum(List<double> Amounts)
        {
            Sum = 0;
            foreach (var value in Amounts)
            {
                Sum = +value;
            }
            return Sum;
        }
    }
}
