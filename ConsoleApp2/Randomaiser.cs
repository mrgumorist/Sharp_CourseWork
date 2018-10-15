using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Randomaiser
    {
        private static int maxPrice = 10000;
        private static int MaxValueSize = 30;
        private static int Id = 0;
        private static Random random = new Random();
        private static readonly List<string> Colors = new List<string>() { "Black", "Blue", "Grey", "White", "Green", "Yellow" };
        private static readonly List<string> Brands = new List<string>() { "Amazon", "Google", "Apple", "Samsung", "AT&T", "KLOK TM" };
        private static readonly List<string> Materials = new List<string>() { "Quartz", "Silk", "Gold", "Bronze", "Glass", "Tile" };
        private static readonly List<string> NamesForAudio = new List<string>() { "Subwoofers", "High Fidelity Speakers", "Outdoor/Indoor Speakers", "Marine Speakers", "Accessories", "Passive Radiators" };
        private static readonly List<string> NamesForVideo = new List<string>() { "TV", "Monitor", "Proector" };
        private static readonly List<string> Details = new List<string>() { "Audio Connector", "sub card", "SATA", "drive", "Audio Addapter", "Video Addapter" };
        public static string RandomName(string name)
        {
            if (name == typeof(AudioTehnick).Name)
            {
                int temp = random.Next(0, NamesForAudio.Count);
                return (NamesForAudio[temp]);
            }
            if (name == typeof(VideoTehnick).Name)
            {
                int temp = random.Next(0, NamesForVideo.Count);
                return (NamesForVideo[temp]);
            }
            else
            {
                int temp = random.Next(0, Details.Count);
                return (Details[temp]);
            }

        }
        public static string RandomBrand() => Brands[random.Next(0, Brands.Count)];
        public static string RandomMaterial() => Materials[random.Next(0, Materials.Count)];
        public static string RandomColor() => Colors[random.Next(0, Colors.Count)];
        public static int RandomPrice() => random.Next(0, maxPrice);
        public static int RandomIntSize() => random.Next(1,MaxValueSize);
        public static int RandomTo3()=> random.Next(3);
        public static int ID() 
        {
            Id++;
            return (Id);
        }
    }
}
