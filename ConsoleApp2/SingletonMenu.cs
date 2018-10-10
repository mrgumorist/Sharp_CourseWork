using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MenuSingle
    {
        private static MenuSingle instance;

        

        protected MenuSingle()
        {
            Store store = new Store();
            // store.PrintStore();

            //  store.RemoveEl();
            //  store.AddNew();
            //store.ChangeEl();
            store.PrintStore();
            Console.WriteLine();
            //store.PrintSortedByName();
            //store.PrintSortedByPrice();
            //store.PrintAllByType();
            // store.SampleOfProductsByPriceXY();
            //store.FindTypeProductAndPrint();
            store.FindByNameProductAndPrint();
            Console.ReadKey();
        }

        public static MenuSingle getInstance()
        {
            if (instance == null)
                instance = new MenuSingle();
            return instance;
        }
    }
}
