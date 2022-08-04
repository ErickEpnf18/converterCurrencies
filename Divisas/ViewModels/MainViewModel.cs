using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Divisas.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private decimal pesos;

        private decimal dollars;

        private decimal yen;

        private decimal pounds;

        private decimal euros;

        private decimal rublo;

        public event PropertyChangedEventHandler PropertyChanged;

     
        public decimal Dollar
        {
            set
            {
                if (dollars != value)
                {
                    dollars = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                }
            }
            get
            {
                return dollars;
            }

        }

        public decimal Yen
        {
            set
            {
                if (yen != value)
                {
                    yen = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Yen"));
                }
            }
            get
            {
                return yen;
            }

        }

        public decimal Pesos
        {
            set
            {
                if (pesos != value)
                {
                    pesos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pesos"));
                }
            }
            get
            {
                return pesos;
            }
        }
        public decimal Pounds
        {
            set
            {
                if (pounds != value)
                {
                    pounds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pounds"));
                }
            }
            get
            {
                return pounds;
            }
        }
        public decimal Euros {
            set
            {
                if (euros != value)
                {
                    euros = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Euros"));
                }
            }
            get
            {
                return euros;
            }
        }

        public decimal Rublos
        {
            set
            {
                if (rublo != value)
                {
                    rublo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rublos"));
                }
            }
            get
            {
                return rublo;
            }
        }


        public ICommand ConverCommand { get { return new RelayCommand(ConvertMoney); } }

        private async void ConvertMoney()
        {
            if (Dollar <= 0)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un valor en dolares mayor a cero (0)", " Ok");
                return;
            }

            Pesos = Dollar / (decimal)0.049;
            Pounds = Dollar / (decimal)1.22;
            Euros = Dollar / (decimal)1.02;
            Yen = Dollar / (decimal)0.0075;
            Rublos = Dollar / (decimal)0.017;


        }
    }
}
