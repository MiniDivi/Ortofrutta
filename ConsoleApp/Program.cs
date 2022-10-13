using Ortofrutta;
using Ortofrutta.Frutta;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //var pear1 = new Pear()
            //{
            //    Color = FruitColor.Green,
            //    Name = "Pear",
            //    Type = FruitType.Fresh
            //};

            var nut = new Nut("Nut", FruitColor.Brown);

            var pear = new Pear("Pera", FruitColor.Green);

            var anguria = new Watermelon("Anguria", FruitType.Fresh, FruitColor.Green);
        }
    }
}