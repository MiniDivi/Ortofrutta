namespace Ortofrutta.Frutta;

public class Pear : Fruit, IFruit
{
    public Pear(string name, FruitColor color) : base(name, FruitType.Fresh, color)
    {
    }
}