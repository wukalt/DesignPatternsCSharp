namespace DesignPatterns.State;

public class ModerationState : IState
{
    private Document _document;

    public ModerationState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        if (_document.CurrentRole is UserRoles.Admin)
        {
            _document.State = new PublishedState(_document);
        }
    }
}
