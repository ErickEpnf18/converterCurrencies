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

        private decimal dollars;


        // new vars
        private decimal real;

        private decimal rupia;
        
        private decimal rubio;
        
        private decimal franco;
        
        private decimal corona;



        



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


        // new vars
        public decimal Real
        {
            set
            {
                if (real != value)
                {
                    real = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Real"));
                }
            }
            get
            {
                return real;
            }

        }

        public decimal Rupia
        {
            set
            {
                if (rupia != value)
                {
                    rupia = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rupia"));
                }
            }
            get
            {
                return rupia;
            }

        }


        public decimal Rubio
        {
            set
            {
                if (rubio!= value)
                {
                    rubio = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rubio"));
                }
            }
            get
            {
                return rubio;
            }

        }

        public decimal Franco
        {
            set
            {
                if (franco != value)
                {
                    franco = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Franco"));
                }
            }
            get
            {
                return franco;
            }

        }


        public decimal Corona
        {
            set
            {
                if (corona != value)
                {
                    corona = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Corona"));
                }
            }
            get
            {
                return corona;
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


            Real = Dollar / (decimal)0.19;
            Rupia = Dollar / (decimal)0.013;
            Rubio = Dollar / (decimal)0.016;
            Franco = Dollar / (decimal)1.05;
            Corona  = Dollar / (decimal)0.099;






        }
    }
}
