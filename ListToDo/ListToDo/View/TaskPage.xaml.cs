using ListToDo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListToDo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : ContentPage
    {
        TaskViewModel contexto = new TaskViewModel();
        public TaskPage()
        {
            InitializeComponent();
            BindingContext = contexto;
        }
    }
}