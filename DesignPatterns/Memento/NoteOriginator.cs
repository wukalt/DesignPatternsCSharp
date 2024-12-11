namespace DesignPatterns.Memento;

public class NoteOriginator
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public NoteOriginator() { }

    public NoteOriginator(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public NoteStateMemento CreateState()
    {
        return new NoteStateMemento(this);
    }

    public void Restore(NoteStateMemento state)
    {
        Title = state.GetTitle();
        Description = state.GetDescription();
    }
}
