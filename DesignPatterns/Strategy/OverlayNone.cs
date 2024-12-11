using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class OverlayNone : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("None");
    }
}
