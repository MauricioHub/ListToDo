using ListToDo.Model;
using ListToDo.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListToDo.ViewModel
{
    public class TaskViewModel: TaskModel
    {
        public ObservableCollection<TaskModel> TaskList { get; set; }
        TaskService servicio = new TaskService();
        TaskModel modelo;

        public TaskViewModel()
        {
            TaskList = servicio.Consultar();
            GuardarCommand = new Command(async () => await Guardar(), () => !Isbusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !Isbusy);
            LimpiarCommand = new Command(Limpiar, () => !Isbusy);
        }

        public Command GuardarCommand { get; set; }
        //public Command ModificarCommand { get; set; }

        public Command EliminarCommand { get; set; }

        public Command LimpiarCommand { get; set; }

        private async Task Guardar()
        {
            Isbusy = true;
            Guid IdPersona = Guid.NewGuid();
            modelo = new TaskModel()
            {
                Name = Name,
                Description = Description,
                DeadLine = DeadLine,
                Id = IdPersona.ToString()
            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private async Task Eliminar()
        {
            Isbusy = true;
            servicio.Eliminar(Id);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private void Limpiar()
        {
            Name = "";
            Description = "";
            DeadLine = "";
            Id = "0";
        }
    }
}
