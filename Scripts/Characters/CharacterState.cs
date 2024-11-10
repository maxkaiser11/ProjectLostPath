using Godot;

public abstract partial class CharacterState : Node
{
    protected Character characterNode;

    public override void _Ready()
    {
        characterNode = GetOwner<Character>();

        SetProcessInput(false);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);

        if (what == GameConstants.NOTFICIATION_ENTER_STATE)
        {
            EnterState();
            SetProcessInput(true);
        }
        else if (what == GameConstants.NOTFICIATION_EXIT_STATE)
        {
            SetProcessInput(false);
            ExitState();
        }
    }

    protected virtual void EnterState() { }
    protected virtual void ExitState() { }



}
