namespace Genshit;

internal class Program
{
    private static void Main()
    {
        List<Character> characters = new()
        {
            new Character(1, "Amber", 100, 300),
            new Character(3, "Lisa", 45, 100),
            new Character(2, "Venti", 300, 450),
            new Character(-1, "Raiden", 60, 100),
            new Character(-2, "Miko", 50, 70),
            new Character(-3, "Sucrose", 125, 150),
        };

        Console.WriteLine("До:");
        foreach (Character i in characters) 
            Console.WriteLine(i.Name);

        Console.WriteLine("\nПо винам");
        foreach (Character bro in Sorts.SortByWinCount(characters, 0, characters.Count - 1))
            Console.WriteLine($"{bro.Name} - {bro.WinCount} wins");

        Console.WriteLine("\nПо имени");
        foreach (Character bro in Sorts.SortByName(characters, 0, characters.Count - 1))
            Console.WriteLine($"{bro.Name}");

        Console.WriteLine("\nПо винрейту");
        foreach (Character bro in Sorts.SortByWinRatio(characters, 0, characters.Count - 1))
            Console.WriteLine($"{bro.Name} - {bro.GetWinRate()} win rate");

        Console.WriteLine("\n По айди");
        foreach (Character bro in Sorts.SortById(characters, 0, characters.Count - 1))
            Console.WriteLine($"{bro.Name} - {bro.Id}");
    }
}