using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit;

namespace MVVM_final_project.ViewModel
{
    using System.ComponentModel;
    using System.Data;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using Model;

    using CommunityToolkit.Mvvm.Messaging;

    using MVVM_final_project.Annotations;
    using MVVM_final_project.Model;
    using MVVM_final_project.View;

    internal class AddEmployeeVM : INotifyPropertyChanged
    {
        public string name { get; set; }

        public int ID { get; set; }

        public float salary { get; set; }

        public ICommand addemployee { get; set; }

        private employee emp;

        public employee _newemployee{get;set;}
            //get
            //{
            //    return emp;
            //}
            //set
            //{
            //    emp = value;
            //    PropertyChanged.Invoke(this , new PropertyChangedEventArgs("_newemployee"));
            //}
        //}

        public AddEmployeeVM()
        {

            _newemployee = new employee(this.name, this.ID, this.salary);

            Messenger.Default.Register<employee>(this, messegereciver);
            name = _newemployee.Name;
            ID = _newemployee.ID;
            salary = _newemployee.Salary;

            addemployee = new MyCommands(canaddemployee, addingemployee);
        }

        public void messegereciver( employee obj )
        {
           _newemployee = obj ;
        }
        


        private void addingemployee(object obj)
        {
            Messenger.Default.Send<employee>(_newemployee);
        }

        private bool canaddemployee(object obj)
        {
            return true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
