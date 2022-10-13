namespace Ortofrutta
{
    public interface IFruit
    {
        /// <summary>
        /// Tipologia definisce se il frutto è fresco o secco.
        /// </summary>
        //string Tipologia { get; set; }

        FruitType Type { get; }

        /// <summary>
        /// Descrive il colore della frutta
        /// </summary>
        FruitColor Color { get; }

        /// <summary>
        /// Nome del frutto
        /// </summary>
        string Name { get; }
    }
}