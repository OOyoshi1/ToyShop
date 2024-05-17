using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop1.DB;

namespace ToyShop1.Classes
{
    internal class EFClass
    {
        public static DBEntities context { get; } = new DBEntities();
    }
}
