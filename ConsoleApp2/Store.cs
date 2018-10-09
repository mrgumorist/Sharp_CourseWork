﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Store
    {
        List<Product> products = new List<Product>();
        int MaxValue = 10000;
        public Store()
        {
            int RandSize = Randomaiser.RandomIntSize();
            for(int id =0; id<RandSize; id++)
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
            int Numtype = 2;
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
                        Console.WriteLine("Ready");
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
               
                Console.WriteLine("Enter Name Of Product");
                string TmpName = Console.ReadLine();
                Console.WriteLine("Enter Name Of Brand");
                string TmpBrand = Console.ReadLine();
                Console.WriteLine("Enter Name Of Material");
                string TmpMaterial = Console.ReadLine();
                Console.WriteLine("Enter Name Of Color");
                string TmpColor = Console.ReadLine();
            int TruePrice = 5500;
            bool repeat2 = true;
            while (repeat2)
            {
                Console.WriteLine("Price ");
                int TmpPrice = -1;
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
                    if(TmpPrice>=1&&TmpPrice<MaxValue)
                    TruePrice = TmpPrice;
                    Console.WriteLine("Okey");
                }
                Console.WriteLine("Go again? Y/N");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat2 = true;
                }
                else
                {
                    repeat2 = false;
                }
                
            }
            if (Numtype == 1)
            {
                var product = new AudioTehnick(TmpName, TmpBrand, TmpMaterial, TmpColor, TruePrice);
                products.Add(product);
                
                Console.WriteLine("Added");
            }
            if (Numtype == 2)
            {
                var product = new VideoTehnick(TmpName, TmpBrand, TmpMaterial, TmpColor, TruePrice);
                products.Add(product);
               
                Console.WriteLine("Added");
            }
            if (Numtype == 3)
            {
                var product = new Detail(TmpName, TmpBrand, TmpMaterial, TmpColor, TruePrice);
                products.Add(product);
              
                Console.WriteLine("Added");
            }

        }
        public void RemoveEl()
        {
            Console.WriteLine("Enter ID of product for delete");
            bool repeat = true;
            int WorkingID = -1;
            
            while (repeat)
            {
                Console.WriteLine($"ENTER NUMBER from 1 to {products.Count}");
                int ID = -1;
                string input = Console.ReadLine();
                try
                {
                    ID = Convert.ToInt32(input);
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
                    if (ID >= 1 && ID <= products.Count())
                    {
                        WorkingID = ID;
                        Console.WriteLine("Susseful");
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
            if (WorkingID != -1)
            {
                var itemToRemove = products.Single(r => r.ID == WorkingID);
                products.Remove(itemToRemove);
            }
        }

    }
}
