namespace DesignPatterns.Memento;

public class NoteStateMemento
{
    private readonly string _title;
    private readonly string _description;

    public NoteStateMemento(NoteOriginator noteOriginator)
    {
        _title = noteOriginator.Title;
        _description = noteOriginator.Description;
    }

    public string GetTitle() => _title;

    public string GetDescription() => _description;
}
