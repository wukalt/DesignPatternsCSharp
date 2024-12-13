namespace DesignPatterns.Command;

public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("OFF");
    }

    public void TurnDim()
    {
        Console.WriteLine("DIM");
    }
}
