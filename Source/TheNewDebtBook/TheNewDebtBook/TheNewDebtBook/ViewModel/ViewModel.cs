using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TheDebtBook.Model;
using TheNewDebtBook.View;
using TheNewDebtBook.ViewModel;

namespace TheDebtBook.ViewModel
{
    public class ViewModel : ObservableCollection<Debts>
    {
        private ObservableCollection<Debts> debts;
        private ObservableCollection<double> SelectedDebt;
        //private List<double> SelectedDebt;

        public ViewModel()
        {
            debts = new ObservableCollection<Debts>();
            debts.Add(new Debts("Mie Kryds Nielsen", 689));
            debts.Add(new Debts("Viggo", -100));
        }

        private string CurrentName;
        private double CurrentAmount;
        private int CurrentSelectedIndex;

        public ObservableCollection<Debts> Debts
        {
            get
            {
                //if (debts == null)
                //{
                //    debts = new ObservableCollection<Debts>();
                //    return debts;
                //}
                //else
                //{
                //    return debts;
                //}
                {
                    return debts;
                }
            }
        }


        public string Name
        {
            get { return CurrentName; }
            set
            {
                if (CurrentName != value)
                {
                    CurrentName = value;
                }
            }
        }

        public double Amount
        {
            get { return CurrentAmount; }
            set
            {
                if (CurrentAmount != value)
                {
                    CurrentAmount = value;
                }
            }
        }

        public int SelectedIndex
        {
            get { return CurrentSelectedIndex; }
            set
            {
                if (CurrentSelectedIndex != value)
                {
                    CurrentSelectedIndex = value;
                }
            }
        }

        public ObservableCollection<double> getHistory
        {
            get
            {
                if (SelectedDebt == null)
                {
                    SelectedDebt = new ObservableCollection<double>();
                    return SelectedDebt;
                }
                else
                {
                    return SelectedDebt;
                }
                
            }
            set
            {
                if (SelectedDebt != value)
                {
                    SelectedDebt = value;
                }
            }
        }

        private ICommand _addDebitorCommand;
        public ICommand AddDebitorCommand
        {
            get
            {
                return _addDebitorCommand ?? (_addDebitorCommand = new CommandHandler(() => addDebitor(), true));
            }
        }

        public void addDebitor()
        {
            if (debts != null)
            {
                
                for (int i = 0; i <= (debts.Count - 1); i++)
                {
                    if (debts[i].Name == CurrentName)
                    {
                        debts[i].Amounts.Add(CurrentAmount);
                        debts[i].CalculateSum(debts[i].Amounts);
                        ObservableCollection<double> NyAmount = debts[i].Amounts;
                        string SammeNavn = debts[i].Name;
                        double NySum = debts[i].CalculateSum(NyAmount) + CurrentAmount;
                        debts.RemoveAt(i);
                        if (debts.Count == 0)
                        {
                            debts.Add(new Debts(SammeNavn, NySum));
                            debts[i].Amounts = NyAmount;
                        }
                        else
                        {
                            debts[i] = new Debts(SammeNavn, NySum);
                            debts[i].Amounts = NyAmount;
                        }
                      
                        return;
                    }
                }
                debts.Add(new Debts(CurrentName,CurrentAmount));
                return;
            }
            else
            {
                debts = new ObservableCollection<Debts>();
                debts.Add(new Debts(CurrentName, CurrentAmount));
            }

        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ?? (_deleteCommand = new CommandHandler(() => deleteDebitor(), true));
            }
        }

        public void deleteDebitor()
        {
            if (debts.Contains(new Debts(CurrentName, CurrentAmount)))
            {
                debts.Remove(new Debts(CurrentName, CurrentAmount));
            }
            else
            {
                MessageBox.Show("Cannot remove debt");
            }
        }
        
        private ICommand _getHistoryCommand;
        public ICommand GetHistoryCommand
        {
            get
            {
                return _getHistoryCommand ?? (_getHistoryCommand = new CommandHandler(() => openHistory(), true));
            }
        }

        public void openHistory()
        {
            SelectedDebt = new ObservableCollection<double>();
            SelectedDebt = Debts[CurrentSelectedIndex].Amounts;
            var historyView = new HistoryWindow();
            historyView.Show();
        }
    }
}

