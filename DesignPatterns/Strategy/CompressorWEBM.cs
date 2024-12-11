using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class CompressorWEBM : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("MP4");
    }
}
