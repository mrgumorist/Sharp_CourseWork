using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Detail : Product
    {

        public Detail()
        {

        }
        public Detail(string name, string brand, string material, string color, int price)
        {
            Name = name;
            Brand = brand;
            Material = material;
            Color = color;
            Price = price;
        }
        public Detail(int id, string brand, string color, string material, string name, int price)
        {
            ID = id;
            Name = name;
            Brand = brand;
            Material = material;
            Color = color;
            Price = price;
        }
    }
}
