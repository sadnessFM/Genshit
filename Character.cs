namespace Genshit;

public class Character
{
    public readonly int Id;
    public readonly string Name;
    public readonly double WinCount;
    private double MatchCount;

    public Character(int id, string name, double winCount, double matchCount)
    {
        Id = id;
        Name = name;
        WinCount = winCount;
        MatchCount = matchCount;
    }

    public double GetWinRate() => Math.Round(MatchCount / WinCount, 2);
}