using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ortofrutta;

namespace ConsoleApp
{
    public class Watermelon : Fruit
    {
        public Watermelon(string name, FruitColor color) :
            base(name, FruitType.Fresh, color)
        {
        }
    }
}
