using ListToDo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToDo.Service
{
    public class TaskService
    {
        public static ObservableCollection<TaskModel> tasks { get; set; }

        public TaskService()
        {
            if (tasks == null)
            {
                tasks = new ObservableCollection<TaskModel>();
            }
        }

        public ObservableCollection<TaskModel> Consultar()
        {
            return tasks;
        }

        public void Guardar(TaskModel modelo)
        {
            tasks.Add(modelo);
        }


        public void Eliminar(string idPersona)
        {
            TaskModel modelo = tasks.FirstOrDefault(p => p.Id == idPersona);
            tasks.Remove(modelo);
        }
    }
}
