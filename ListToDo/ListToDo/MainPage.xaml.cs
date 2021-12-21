using ListToDo.View;
using ListToDo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListToDo
{
    public partial class MainPage : ContentPage
    {
        TaskViewModel contexto = new TaskViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = contexto;
        }

        private async void OnbtnSecondXaml(object sender, EventArgs args)
        {
            // Write code here to move on second Xaml 
            await Navigation.PushModalAsync(new TaskPage());
        }
    }
}
