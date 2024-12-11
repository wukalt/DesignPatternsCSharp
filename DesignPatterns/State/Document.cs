namespace DesignPatterns.State;

public class Document
{
    public IState State { get; set; }
    public UserRoles CurrentRole { get; set; }

    public Document(UserRoles role)
    {
        State = new DraftState(this);
        CurrentRole = role;
    }

    public void Publish()
    {
        State.Publish();
    }
}
