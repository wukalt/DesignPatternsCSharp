using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class OverlayBlackAndWhite : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Black and White");
    }
}
