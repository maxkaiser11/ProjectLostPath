using Godot;

public partial class StateMachine : Node
{
    [Export] private Node currentState;
    [Export] private Node[] states;

    public override void _Ready()
    {
        if (states == null || states.Length == 0)
        {
            GD.Print("Manually populating states array in _Read()...");
            states = new Node[] { GetNode("IdleState"), GetNode("MoveState") };
        }

        if (currentState == null && states.Length > 0)
        {
            currentState = states[0];
            currentState.Notification(GameConstants.NOTFICIATION_ENTER_STATE);
            GD.Print("Initial state set to: " + currentState.GetType().Name);
        }
    }

    public void SwitchState<T>() where T : Node
    {
        Node newState = null;
        if (states == null)
        {
            GD.Print("State is null");
        }
        else if (states.Length == 0)
        {
            GD.Print("States array is empty");
        }

        foreach (Node state in states)
        {
            if (state is T)
            {
                newState = state;
                break;
            }
        }
        if (newState == null)
        {
            return;
        }

        currentState.Notification(GameConstants.NOTFICIATION_ENTER_STATE);
        currentState = newState;
        currentState.Notification(GameConstants.NOTFICIATION_EXIT_STATE);
    }
}
