using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Menu
    {
        public Menu()
        {
            Store store = new Store();
            store.PrintStore();
            Console.ReadKey();
            store.AddNew();
            store.PrintStore();
        }
    }
}
