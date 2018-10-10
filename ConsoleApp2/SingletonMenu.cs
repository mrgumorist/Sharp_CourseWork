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
            int MenuEl = -1;
            while(MenuEl!=0)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("[->     HELLO! I AM MENU HELPER IN YOUR FIRM     <-]");
                Console.WriteLine("[-> For Exit                             Enter 0 <-]");
                Console.WriteLine("[-> For Clearing Console                 Enter 1 <-]");
                Console.WriteLine("[-> For Print All Firm                   Enter 2 <-]");
                Console.WriteLine("[-> For Add new Element to firm          Enter 3 <-]");
                Console.WriteLine("[-> For Remove Element from firm         Enter 4 <-]");
                Console.WriteLine("[-> For Change Element in fitm           Enter 5 <-]");
                Console.WriteLine("[-> For watching printed sorted by name  Enter 6 <-]");
                Console.WriteLine("[-> For watching printed sorted by price Enter 7 <-]");
                Console.WriteLine("[-> For print all by type(chose by num)  Enter 8 <-]");
                Console.WriteLine("[-> For print sample products by PriceXY Enter 9 <-]");
                Console.WriteLine("[-> For find type product and print all Enter 10 <-]");
                Console.WriteLine("[-> For find by name product and show   Enter 11 <-]");
                Console.WriteLine("[-> For find avg in firm by type        Enter 12 <-]");
                Console.WriteLine("[-> For change price by plus proc       Enter 13 <-]");
                Console.WriteLine("[-> For change price by minus proc      Enter 14 <-]");
                Console.WriteLine("[-> For Save to file                    Enter 15 <-]");
                Console.WriteLine("[-> For Open end read from file         Enter 16 <-]");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadKey();
                Console.WriteLine("Enter Element");
                MenuEl = 15;
                if (MenuEl==0)
                {
                    break;
                }
                if(MenuEl==1)
                {
                    Console.Clear();
                }
                if(MenuEl==15)
                {
                    store.SaveToFile();
                }
                MenuEl = -1;
            }
            
            
            
            
            
            
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

            //store.FindByNameProductAndPrint();
            //store.AvgPriceType();
       
           // store.ChangePricePlus();
            //store.PrintStore();
           // store.ChangePriceMinus();
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
