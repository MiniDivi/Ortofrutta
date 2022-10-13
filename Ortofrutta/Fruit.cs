namespace Ortofrutta;

public abstract class Fruit : IFruit{

    public FruitType Type { get; private set; }
    public FruitColor Color { get; private set; }
    public string Name { get; private set; }

    public Fruit(string name, FruitType type, FruitColor color)
    {
        Name = name;
        Type = type;
        Color = color;
    }
}