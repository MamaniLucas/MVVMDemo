using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
            //Enlace de una vista a un view models
            //Instancia: Enlace Bidireccional

            this.BindingContext = new ViewModels.OperacionesViewModel();
        }
    }
}