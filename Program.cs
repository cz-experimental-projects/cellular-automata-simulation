namespace Simulation;

public static class Program
{
    public static void Main()
    {
        using var game = new Simulation();
        game.Run();
    }
}