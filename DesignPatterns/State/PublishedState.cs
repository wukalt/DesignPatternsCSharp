namespace DesignPatterns.State;

public class PublishedState : IState
{
    private Document _document;

    public PublishedState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        return;
    }
}
