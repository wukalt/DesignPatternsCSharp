using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class CompressMOV : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("MOV");
    }
}
