using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace ConsoleApp2
{
    class Store
    {

        List<Product> products = new List<Product>();
        protected delegate void Message();
        public Store()
        {
            Message Event ;
            int RandSize = Randomaiser.RandomIntSize();
            for (int id = 0; id < RandSize; id++)
            {
                
                int RandType = Randomaiser.RandomTo3();
                if (RandType == 0)
                {
                    var temp = new AudioTehnick();
                    products.Add(temp);
                    Event = AudioMess;
                }
                if (RandType == 1)
                {
                    var temp = new VideoTehnick();
                    products.Add(temp);
                    Event = VideoMess;
                }
                else
                {
                    var temp = new Detail();
                    products.Add(temp);
                    Event = DetailMess;
                }

                Event();
            }

        }
        private static void NULLMess()
        {
            Console.WriteLine("Unknown");
        }
        private static void AudioMess()
        {
            Console.WriteLine("DELEGATE MESSAGE: AudioMess added in list");
        }
        private static void VideoMess()
        {
            Console.WriteLine("DELEGATE MESSAGE: VideoMess added in list");
        }
        private static void DetailMess()
        {
            Console.WriteLine("DELEGATE MESSAGE: DetailMess added in list");
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
            Message mes;
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
               
                mes = AddType1Delegate;
            }
            if (Numtype == 2)
            {
                var product = new VideoTehnick(TmpName, TmpBrand, TmpMaterial, TmpColor, TruePrice);
                products.Add(product);
                mes = AddType2Delegate;
                Console.WriteLine("Added");
            }
            if (Numtype == 3)
            {
                var product = new Detail(TmpName, TmpBrand, TmpMaterial, TmpColor, TruePrice);
                products.Add(product);
                mes = AddType3Delegate;
                Console.WriteLine("Added");
            }

        }
        protected static void AddType1Delegate()
        {

            Console.WriteLine("Delegate message: Added el by VideoTehnick type");
        }
        protected static void AddType2Delegate()
        {


            Console.WriteLine("Delegate message: Added el by Detail type");
        }
        protected static void AddType3Delegate()
        {


            Console.WriteLine("Delegate message: Added el by AudioTehnick type");
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
            int AvgAudioTehnick =0; 
            if(AudioTehnickCount!=0)
            {
                AvgAudioTehnick=AllPriceAudioTehnick / AudioTehnickCount;
            }           

            int AvgVideoTehnick =0;
            if(VideoTehnickCount!=0)
               {
            AvgVideoTehnick=AllPriceVideoTehnick / VideoTehnickCount;
            }
            int AvgDetail =0; 
            if(DetailCount!=0)
                {
                AvgDetail=AllPriceDetail / DetailCount;
                }
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

            string Audio = "Audio";
            string Video = "Video";
            string Detaiil = "Detail";
            BinaryWriter binaryWriter;
            try
            {
                binaryWriter = new BinaryWriter(new FileStream("Users.txt", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            try
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i] is VideoTehnick)
                    {
                        binaryWriter.Write(Video);
                        binaryWriter.Write((products[i] as VideoTehnick).ID);
                        binaryWriter.Write((products[i] as VideoTehnick).Brand);
                        binaryWriter.Write((products[i] as VideoTehnick).Color);
                        binaryWriter.Write((products[i] as VideoTehnick).Material);
                        binaryWriter.Write((products[i] as VideoTehnick).Name);
                        binaryWriter.Write((products[i] as VideoTehnick).Price);




                    }
                    if (products[i] is AudioTehnick)
                    {
                        binaryWriter.Write(Audio);
                        binaryWriter.Write((products[i] as AudioTehnick).ID);
                        binaryWriter.Write((products[i] as AudioTehnick).Brand);
                        binaryWriter.Write((products[i] as AudioTehnick).Color);
                        binaryWriter.Write((products[i] as AudioTehnick).Material);
                        binaryWriter.Write((products[i] as AudioTehnick).Name);
                        binaryWriter.Write((products[i] as AudioTehnick).Price);
                    }
                    if (products[i] is Detail)
                    {
                        binaryWriter.Write(Detaiil);
                        binaryWriter.Write((products[i] as Detail).ID);
                        binaryWriter.Write((products[i] as Detail).Brand);
                        binaryWriter.Write((products[i] as Detail).Color);
                        binaryWriter.Write((products[i] as Detail).Material);
                        binaryWriter.Write((products[i] as Detail).Name);
                        binaryWriter.Write((products[i] as Detail).Price);

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFromFile()
        {
            try
            {
                using (BinaryReader b = new BinaryReader(File.Open("Users.txt", FileMode.Open)))
                {

                    while (b.BaseStream.Position != b.BaseStream.Length)
                    {
                        string UserChoise = b.ReadString();
                        int ID = b.ReadInt32();
                        string Brand = b.ReadString();
                        string Color = b.ReadString();
                        string Material = b.ReadString();
                        string Name = b.ReadString();
                        int Price = b.ReadInt32();

                        if (UserChoise == "Audio")
                        {
                            products.Add(new AudioTehnick(ID, Brand,Color,Material,Name,Price));

                        }
                        if(UserChoise== "Video")
                        {
                            products.Add(new VideoTehnick(ID, Brand, Color, Material, Name, Price));

                        }
                        if (UserChoise == "Detail")
                        {
                            products.Add(new Detail(ID, Brand, Color, Material, Name, Price));

                        }



                    }
                }
            }
            catch (IOException E)
            {
                Console.WriteLine(E.Message);
            }
        }





    }
}
