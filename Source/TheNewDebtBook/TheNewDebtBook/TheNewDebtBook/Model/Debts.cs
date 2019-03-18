using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TheDebtBook.Model
{
    public class Debts
    {
        public String Name { get; set; }
        public double Sum { get; set; }
        public ObservableCollection<double> Amounts;
        //public List<double> Amounts;

        public Debts(string name, double currentAmount)
        {
            if (Amounts != null)
            {
                Name = name;
                Amounts.Add(currentAmount);
                CalculateSum(Amounts);
            }
            else
            {
                Amounts = new ObservableCollection<double>();
                Name = name;
                Amounts.Add(currentAmount);
                CalculateSum(Amounts);
            }
        }

        public double CalculateSum(ObservableCollection<double> Amounts)
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
