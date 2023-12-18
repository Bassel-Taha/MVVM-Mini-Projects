using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_final_project.Model
{
    using System.Windows.Markup;

    public class employee
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public float Salary { get; set; }

        public string? Image { get; set; }

        public employee (string name, int id, float salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
            Image = null;
        }

    }
}
