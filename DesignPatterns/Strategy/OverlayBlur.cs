using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class OverlayBlur : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Blur");
    }
}
