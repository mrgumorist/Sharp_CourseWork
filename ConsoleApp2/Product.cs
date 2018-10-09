using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product
    {

     
     

        virtual public string Name { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }



        public Product()
        {
            Name = Randomaiser.RandomName(this.GetType().Name);
            Brand = Randomaiser.RandomBrand();
            Material = Randomaiser.RandomMaterial();
            Color = Randomaiser.RandomColor();
            Price = Randomaiser.RandomPrice();



        }
        public Product(string name, string brand, string material, string color, int price)
        {
            Name = name;
            Brand = brand;
            Material = material;
            Color = color;
            Price = price;
        }
        public override string ToString()=>($"Name {Name} Material {Material} Color {Color} Price {Price} type {this.GetType().Name}" ); 
        

      


    }
}
