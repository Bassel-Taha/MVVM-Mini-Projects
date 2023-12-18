using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_final_project.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Net.Sockets;
    using System.Security.AccessControl;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media.Imaging;
    using CommunityToolkit.Mvvm;
    using CommunityToolkit.Mvvm.Messaging;

    using MVVM_final_project.Model;
    using MVVM_final_project.View;

    public class windows1ViewModel
    {
        public employee _Selcetedemployee { get; set; }

        public ObservableCollection<employee> Employees { get; set; }

        public employee Newmep { get; set; }

        public ICommand AddingNewEmp
        {
            get; set;
        }

        public windows1ViewModel()
        {
            AddingNewEmp = new MyCommands(cando, AddEmp);
            Employees = new ObservableCollection<employee>();
            this.Employees.Add(new employee("bassel", 1, 10000));


            Messenger.Default.Register<employee>(
                this, messegereciver);
            Employees.Add(Newmep);
        }

        public void messegereciver(employee obj)
        {
            Newmep = obj;
        }

        private void AddEmp(object obj)
        {
            var AddingEmpWindow = new AddEmployee();
            AddingEmpWindow.Show();
            if (_Selcetedemployee != null)
            {
                Messenger.Default.Send<employee>(_Selcetedemployee);
            }
        }

        private bool cando(object obj)
        {
            return true;
        }
    }
}
