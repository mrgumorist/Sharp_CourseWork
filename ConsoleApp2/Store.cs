using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Store
    {
        List<Product> products = new List<Product>();
        
        public Store()
        {
            int RandSize = Randomaiser.RandomIntSize();
            for(int i =0; i<RandSize; i++)
            {
                int RandType = Randomaiser.RandomTo3();
                if (RandType == 0)
                {
                    var temp = new AudioTehnick();
                    products.Add(temp);
                }
                if (RandType == 1)
                {
                    var temp = new VideoTehnick();
                    products.Add(temp);
                }
                if (RandType == 2)
                {
                    var temp = new Detail();
                    products.Add(temp);
                }


            }
            
        }
        public void PrintStore()
        {
            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void AddNew()
        {
            Console.WriteLine("Enter type of product");
            bool repeat = true;
            int Numtype = -1;
            while (repeat)
            {
                Console.WriteLine("Enter 1 for AudioType, 2 for Video type, 3 for detail");
                int NumberOftype = -1;
                string input = Console.ReadLine();
                try
                {
                    NumberOftype = Convert.ToInt32(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (NumberOftype == 1 || NumberOftype == 2 || NumberOftype == 3)
                    {
                        Numtype = NumberOftype;
                    }

                    else Console.WriteLine("Incorect Type");
                }
                Console.WriteLine("Go again? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }

            } 
                Console.Clear();
                Console.WriteLine("Enter Name Of Product");
                string TmpName = Console.ReadLine();
                Console.WriteLine("Enter Name Of Brand");
                string TmpBrand = Console.ReadLine();
                Console.WriteLine("Enter Name Of Material");
                string TmpMaterial = Console.ReadLine();
                Console.WriteLine("Enter Name Of Color");
                string TmpColor = Console.ReadLine();
            int TmpPrice = -1;
            repeat = true;
            while (repeat)
            {
                Console.WriteLine("Price ");
              
                string input = Console.ReadLine();
                try
                {
                    TmpPrice = Convert.ToInt32(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {


                    Console.WriteLine("Okey");
                }
                Console.WriteLine("Go again? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
                
            }
            Product product = new Product(TmpName,TmpBrand,TmpMaterial,TmpColor,TmpPrice);
            products.Add(product);
            Console.WriteLine("Added");
        }


    }
}
