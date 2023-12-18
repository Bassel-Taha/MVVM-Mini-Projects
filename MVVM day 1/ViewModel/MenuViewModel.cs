using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_day_1.Model;

namespace MVVM_day_1.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Windows.Controls;

    using MVVM_day_1.Model;

    public class MenuViewModel
    {
        public ObservableCollection<Food> menu { get; set; }

        public MenuViewModel()
        {
            menu = new ObservableCollection<Food>();
            menu.Add(new Food { name = "burger", coast = 2f , Image = "\\Model\\images\\burger.jpg" });
            menu.Add(new Food { name = "french fries", coast = 1.5f , Image = "\\Model\\images\\frenchfries.jpg" });
            menu.Add(new Food { name = "pasta", coast = 5, Image = "\\Model\\images\\pasta.jpg" });
            menu.Add(new Food { name = "pizza", coast = 7.5f, Image = "\\Model\\images\\pizza.jpg" });

        }
    }
}
