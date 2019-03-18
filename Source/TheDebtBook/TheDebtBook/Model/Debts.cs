using System;
using System.Collections.Generic;
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
        public List<double> Amount;

        public double CalculateSum(List<double> Amount)
        {
            Sum = 0;
            foreach (var value in Amount)
            {
                Sum =+ value;
            }

            return Sum;
        }


    }
}
