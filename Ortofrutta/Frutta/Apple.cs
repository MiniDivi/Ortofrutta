namespace Ortofrutta.Frutta
{
    internal class Apple : Fruit, IFruit
    {
        public Apple(string name, FruitColor color) : base(name, FruitType.Fresh, color)
        {
        }
    }
}