using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    [Serializable]    
    public class Product
    {




        virtual public string Name { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int ID{get; set;}


        public Product()
        {
            Name = Randomaiser.RandomName(this.GetType().Name);
            Brand = Randomaiser.RandomBrand();
            Material = Randomaiser.RandomMaterial();
            Color = Randomaiser.RandomColor();
            Price = Randomaiser.RandomPrice();
            ID = Randomaiser.ID();

        }
        public Product( string name, string brand, string material, string color, int price)
        {
            Name = name;
            Brand = brand;
            Material = material;
            Color = color;
            Price = price;
        }
        public override string ToString()=>($"ID {ID} Name {Name} Material {Material} Color {Color} Price {Price} type {this.GetType().Name}" ); 
        public void ChangePricePlus(int proc)
        {
            int TempPrice = Price;
            TempPrice = TempPrice / 100;
            TempPrice = TempPrice * (100+proc);
            Price = TempPrice;
        }
        public void ChangePriceMinus(int proc)
        {
            int TempPrice = Price;
            TempPrice = TempPrice / 100;
            TempPrice = TempPrice * (100 - proc);
            Price = TempPrice;
        }



    }
}
