using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Helper
    {
        static public int MaxValue { get; set; } = 10000;
        static public int Weiht { get; set; } = 95;
        static public int Height { get; set; } = 40;
        static private int MaxProc=100;
        public static int ReturnNumXY()
        {

            bool repeat = true;
            int number = 1;
            while (repeat)
            {
                Console.WriteLine("Enter number");
                int NumberOftype = -1;
                string input = Console.ReadLine();
                try
                {
                    NumberOftype = Convert.ToInt32(input);
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
                    if (NumberOftype >= 0 && NumberOftype < MaxValue)
                    {
                        number = NumberOftype;
                        Console.WriteLine("Ready");
                    }

                    else Console.WriteLine("Incorect Type");
                }
                Console.WriteLine("Go again? Y/N");

            }
            return number;

        }

        public static int ReturnNumType()
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
            return Numtype;




        }

        public static int ReturnTruePrice()
        {
           
            bool repeat = true;
            int TruePrice = 500;
            while (repeat)
            {
                Console.WriteLine("Enter price");
                int Price = -1;
                string input = Console.ReadLine();
                try
                {
                    Price = Convert.ToInt32(input);
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
                    if (Price>0|| Price<Helper.MaxValue)
                    {
                        TruePrice = Price;
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
            return TruePrice;
        }

        public static int ReturnProc()
        {
            bool repeat = true;
            int TrueProc = 5;
            while (repeat)
            {
                Console.WriteLine($"Enter proc from 1 to {Helper.MaxProc}");
                int Price = -1;
                string input = Console.ReadLine();
                try
                {
                    Price = Convert.ToInt32(input);
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
                    if (Price > 0 || Price < Helper.MaxProc+1)
                    {
                        TrueProc = Price;
                        Console.WriteLine("Ready");
                    }

                    else Console.WriteLine("Incorect number");
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
            return TrueProc;
        }

        public static void PrintLine()
        {
          
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write('*');
            }
        }

        public static int HelperMenu()
            {
            bool repeat = true;
            int ElMenu = -1;
            while (repeat)
            {
                Console.WriteLine("Enter El from 0 to 16");
                int El = -1;
                string input = Console.ReadLine();
                try
                {
                    El = Convert.ToInt32(input);
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
                    if (El > -1 || El <17)
                    {
                        ElMenu = El;
                        Console.WriteLine("Ready");
                    }

                    else Console.WriteLine("Incorect number");
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
            return ElMenu;
        }
         
    }
}
