using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class VideoStorage
{
    private ICompressor _compressor;
    private IOverlay _overlay;

    public VideoStorage(ICompressor compressor, IOverlay overlay)
    {
        _compressor = compressor;
        _overlay = overlay;
    }

    public void SetCompressor(ICompressor compressor)
    {
        _compressor = compressor;
    }

    public void SetOverlay(IOverlay overlay)
    {
        _overlay = overlay;
    }

    public void Store(string fileName)
    {
        Console.WriteLine($"{fileName}.{_compressor} -> {_overlay}");
    }
}
