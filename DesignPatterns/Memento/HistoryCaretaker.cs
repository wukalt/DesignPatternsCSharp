namespace DesignPatterns.Memento;

public class HistoryCaretaker
{
    private List<NoteStateMemento> _noteStates = new();
    private NoteOriginator _noteOriginator;

    public HistoryCaretaker(NoteOriginator originator)
    {
        _noteOriginator = originator;
    }

    public void Backup()
    {
        _noteStates.Add(_noteOriginator.CreateState());
    }

    public void Restore()
    {
        if (_noteStates.Count > 0)
        {
            NoteStateMemento lastState = _noteStates.Last();
            _noteStates.Remove(lastState);

            _noteOriginator.Restore(lastState);
        }
    }
}
