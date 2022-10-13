namespace Ortofrutta.Frutta;

public class Nut : Fruit, IFruit
{
    public Nut(string name, FruitColor color) : base(name, FruitType.Dry, color)
    {
    }
}