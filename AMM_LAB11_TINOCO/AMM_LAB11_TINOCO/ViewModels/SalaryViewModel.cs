using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AMM_LAB11_TINOCO.ViewModels
{
    public class SalaryViewModel : INotifyPropertyChanged
    {
        private int salary;
        public int Salary
        {
            get { return salary; } 
            set
            {
                if (salary != value)
                {
                    salary = value;
                    OnPropertyChanged();
                }
            }
        }

        public int gratification;
        public int Gratification
        {
            get { return gratification; }
            set
            {
                if (gratification != value)
                {
                    gratification = value;
                    OnPropertyChanged();
                }
            }
        }

        public int discount;
        public int Discount
        {
            get { return discount; }
            set
            {
                if (discount != value)
                {
                    discount = value;
                    OnPropertyChanged();
                }
            }
        }

        public int netSalary;
        public int NetSalary
        {
            get { return netSalary; }
            set
            {
                if (netSalary != value)
                {
                    netSalary = value;
                    OnPropertyChanged();
                }
            }
        }

        public int netFinalSalary;
        public int NetFinalSalary
        {
            get { return netFinalSalary; }
            set
            {
                if (netFinalSalary != value)
                {
                    netFinalSalary = value;
                    OnPropertyChanged();
                }
            }
        }

        public int tax;
        public int Tax
        {
            get { return tax; }
            set
            {
                if (tax != value)
                {
                    tax = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalculateNetSalary { protected set; get; }
        public ICommand CalculateNetFinalSalary { protected set; get; }
        public ICommand CalculateTax { protected set; get; }

        public SalaryViewModel()
        {
            CalculateNetSalary = new Command(() =>
            {
                NetSalary = Salary + Gratification;
            });

            CalculateNetFinalSalary = new Command(() =>
            {
                NetFinalSalary = NetSalary - Discount;
            });

            CalculateTax = new Command(() =>
            {
                Tax = (int)(Salary * 0.08);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
