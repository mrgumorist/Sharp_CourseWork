﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp2
{

    class Store
    {
        List<Product> products = new List<Product>();
        public Store()
        {
            int RandSize = Randomaiser.RandomIntSize();
            for (int id = 0; id < RandSize; id++)
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
            Console.WriteLine();
            Helper.PrintLine();

            foreach (var item in products)
            {

                Console.WriteLine($"{item.ToString()}");
            }
            Helper.PrintLine();
            Console.WriteLine();
        }

        public void AddNew()
        {
            int Numtype = Helper.ReturnNumType();

            Console.WriteLine("Enter Name Of Product");
            string TmpName = Console.ReadLine();
            Console.WriteLine("Enter Name Of Brand");
            string TmpBrand = Console.ReadLine();
            Console.WriteLine("Enter Name Of Material");
            string TmpMaterial = Console.ReadLine();
            Console.WriteLine("Enter Name Of Color");
            string TmpColor = Console.ReadLine();
            int TruePrice = Helper.ReturnTruePrice();


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
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException)
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

        public void ChangeEl()
        {
            Console.WriteLine($"Enter ID from 1 to {products.Count}");
            bool repeat = true;
            int RealID = 2;
            while (repeat)
            {
                Console.WriteLine("Enter id: ");
                int Id = 1;
                string input = Console.ReadLine();
                try
                {
                    Id = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (Id >= 1 && Id < products.Count)
                    {
                        RealID = Id;
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
                int TmpPrice = 1000;
                string input = Console.ReadLine();
                try
                {
                    TmpPrice = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (TmpPrice >= 1 && TmpPrice < Helper.MaxValue)
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

            int IndexOfId = FindIndex(RealID);
            products[IndexOfId].Color = TmpColor;
            products[IndexOfId].Brand = TmpBrand;
            products[IndexOfId].Material = TmpMaterial;
            products[IndexOfId].Name = TmpName;
            products[IndexOfId].Price = TruePrice;
            Console.WriteLine("Added");





        }

        public void PrintSortedByName()
        {
            List<Product> SecondList = new List<Product>();

            SecondList = products.OrderBy(q => q.Name).ToList();
            Helper.PrintLine();
            foreach (var item in SecondList)
            {
                Console.WriteLine(item.ToString());
            }
            Helper.PrintLine();

        }

        public void PrintSortedByPrice()
        {
            List<Product> SecondList = new List<Product>();

            SecondList = products.OrderBy(q => q.Price).ToList();
            Helper.PrintLine();

            foreach (var item in SecondList)
            {
                Console.WriteLine(item.ToString());
            }
            Helper.PrintLine();
        }

        public void PrintAllByType()
        {
            int Numtype = Helper.ReturnNumType();
            if (Numtype == 1)
            {
                string Type = new AudioTehnick().GetType().Name;
                Helper.PrintLine();
                foreach (var item in products)
                {
                    if (item.GetType().Name == Type)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                Helper.PrintLine();
            }
            if (Numtype == 2)
            {
                string Type = new VideoTehnick().GetType().Name;
                Helper.PrintLine();
                foreach (var item in products)
                {
                    if (item.GetType().Name == Type)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                Helper.PrintLine();
            }
            if (Numtype == 3)
            {
                string Type = new Detail().GetType().Name;
                Helper.PrintLine();
                foreach (var item in products)
                {
                    if (item.GetType().Name == Type)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                Helper.PrintLine();

            }
        }

        public void SampleOfProductsByPriceXY()
        {

            Console.WriteLine("Enter x");
            int x = Helper.ReturnNumXY();
            Console.WriteLine("Enter y");
            int y = Helper.ReturnNumXY();
            var SecondList = products.Where(d => d.Price >= x && d.Price <= y).ToList();
            Helper.PrintLine();
            foreach (var item in SecondList)
            {
                Console.WriteLine(item.ToString());
            }
            Helper.PrintLine();
            if (SecondList == null)
            {
                Console.WriteLine("NULL");
            }




        }

        public void FindTypeProductAndPrint()
        {
            Console.WriteLine("Enter type of Product(Avalinle are AudioTehnick , VideoTehnick, Detail");
            string Type = Console.ReadLine();
            Helper.PrintLine();
            foreach (var item in products)
            {
                if (item.GetType().Name == Type)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            Helper.PrintLine();



        }

        public void FindByNameProductAndPrint()
        {
            Console.WriteLine("Enter name product for finding");
            string Name = Console.ReadLine();
            Helper.PrintLine();
            foreach (var item in products)
            {
                if (item.Name == Name)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            Helper.PrintLine();



        }

        public void AvgPriceType()
        {
            int AllPriceAudioTehnick = 0;
            int AllPriceVideoTehnick = 0;
            int AllPriceDetail = 0;
            int AudioTehnickCount = 0;
            int VideoTehnickCount = 0;
            int DetailCount = 0;

            foreach (var item in products)
            {
                if (item.GetType().Name == new AudioTehnick().GetType().Name)
                {
                    AllPriceAudioTehnick += item.Price;
                    AudioTehnickCount++;
                }
                if (item.GetType().Name == new VideoTehnick().GetType().Name)
                {
                    AllPriceVideoTehnick += item.Price;
                    VideoTehnickCount++;
                }
                else
                    AllPriceDetail += item.Price;
                DetailCount++;

            }
            int AvgAudioTehnick = AllPriceAudioTehnick / AudioTehnickCount;
            int AvgVideoTehnick = AllPriceVideoTehnick / VideoTehnickCount;
            int AvgDetail = AllPriceDetail / DetailCount;
            Console.WriteLine($"Type: AudioTehnick Average Price:{AvgAudioTehnick}");
            Console.WriteLine($"Type: VideoTehnick Average Price:{AvgVideoTehnick}");
            Console.WriteLine($"Type: Detail Average Price:{AvgDetail}");

        }

        public void ChangePricePlus()
        {

            Console.WriteLine($"Enter ID from 1 to {products.Count}");
            bool repeat = true;
            int RealID = 2;
            while (repeat)
            {
                Console.WriteLine("Enter id: ");
                int Id = 1;
                string input = Console.ReadLine();
                try
                {
                    Id = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (Id >= 1 && Id < products.Count + 1)
                    {
                        RealID = Id;
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
            Console.WriteLine("Enter proc for plus price");
            int Proc = Helper.ReturnProc();
            foreach (var item in products)
            {
                if (item.ID == RealID)
                {
                    item.ChangePricePlus(Proc);
                    break;
                }
            }





        }

        public void ChangePriceMinus()
        {
            Console.WriteLine($"Enter ID from 1 to {products.Count}");
            bool repeat = true;
            int RealID = 2;
            while (repeat)
            {
                Console.WriteLine("Enter id: ");
                int Id = 1;
                string input = Console.ReadLine();
                try
                {
                    Id = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
                finally
                {
                    if (Id >= 1 && Id < products.Count + 1)
                    {
                        RealID = Id;
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
            Console.WriteLine("Enter proc for plus price");
            int Proc = Helper.ReturnProc();
            foreach (var item in products)
            {
                if (item.ID == RealID)
                {
                    item.ChangePriceMinus(Proc);
                    break;
                }
            }

        }

        int FindIndex(int id)
        {
            int ID = 0;
            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].ID == id)
                {
                    ID = i;
                    return ID;
                }
            }
            return 0;
        }

       public void SaveToFile()
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream("File.xml", FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, products);


                Console.WriteLine("Объект сериализован");
            }



        }


    }
}
