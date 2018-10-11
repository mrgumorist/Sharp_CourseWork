using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IProduct
    {
         string Brand { get; set; }
         string Material { get; set; }
         string Color { get; set; }
         int Price { get; set; }
         int ID { get; set; }

    }
}
