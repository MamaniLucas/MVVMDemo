using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo.ViewModels
{
    //Hereda de ViewModelBase
    public class OperacionesViewModel : ViewModelBase
    {

        //Las propiedades cambian

        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }



        int resultadoSuma;
        public int ResultadoSuma
        {
                    get { return resultadoSuma; }
                    set
                    {
                        if (resultadoSuma != value)
                        {
                            resultadoSuma = value;
                            OnPropertyChanged();
                        }
                    }
        }


        //comandos  = funciones
        public ICommand Sumar { protected get; set; }
        

        //Implementar la lógica 
        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = Valor1 + Valor2;
            });

        }
        
    }
}
