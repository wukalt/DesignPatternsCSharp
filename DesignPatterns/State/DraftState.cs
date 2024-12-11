﻿namespace DesignPatterns.State;

public class DraftState : IState
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        if (_document.CurrentRole is UserRoles.Editor or UserRoles.Admin)
        {
            _document.State = new ModerationState(_document);
        }
    }
}
