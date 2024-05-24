using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop1.DB;

namespace ToyShop1.Classes
{
    public static class ProductClass
    {
        public static ObservableCollection<Product> products= new ObservableCollection<Product>();
    }
}
