using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ListToDo.Model
{
    public class TaskModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;

        public bool Isbusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }

        private string deadLine;

        public string DeadLine
        {
            get { return deadLine; }
            set
            {
                deadLine = value;
            }
        }

    }
}
