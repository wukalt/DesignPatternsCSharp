using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class CompressorMP4 : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("MP4");
    }
}
