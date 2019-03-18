using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDebtBook.Model;

namespace TheDebtBook.ViewModel
{
    class ViewModel : ObservableCollection<Debts>
    {

        private ObservableCollection<Debts> debts;
        private string CurrentName;
        private double CurrentAmount;
        private int CurrentSelectedIndex;

        public void addDebitor()
        {
            for (int i = 0; i < (debts.Count - 1); i++)
            {
                if (debts[i].Name == CurrentName)
                {
                    debts[i].Amounts.Add(CurrentAmount);
                    debts[i].CalculateSum(debts[i].Amounts);
                }
            }

            debts.Add(new Debts(CurrentName, CurrentAmount));

        }

        public void deleteDebitor()
        {
            if (debts.Contains(new Debts(CurrentName, CurrentAmount)))
            {
                debts.Remove(new Debts(CurrentName, CurrentAmount));
            }
            else
            {
                MessageBox.Show("DEN FINDES FJOLLEHOVEDE :D !");
            }

        }

        public List<double> getHistory()
        {
            return debts[CurrentSelectedIndex].Amounts;
        }




    }
}
