using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_final_project.Model
{
    using System.Windows.Input;

    internal class MyCommands : ICommand
    {
        public Action<object> doit { get; set; }

        public Predicate<object> cando { get; set; }
        public MyCommands(Predicate<object> cando, Action <object> doit)
        {
            this.cando = cando;
            this.doit = doit;
        }



        public bool CanExecute(object parameter)
        {
            return true;
        }



        public void Execute(object parameter)
        {
           doit(parameter);
        }





        public event EventHandler? CanExecuteChanged;
    }


}
