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
            Menu menu = new Menu();
        }

        public static MenuSingle getInstance()
        {
            if (instance == null)
                instance = new MenuSingle();
            return instance;
        }
    }
}
