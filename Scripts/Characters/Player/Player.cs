
using Godot;

public partial class Player : Character
{

    [Export] private AnimatedSprite2D spriteNode;
    [Export] public float MaxSpeed = 200f;


    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            GameConstants.INPUT_MOVE_LEFT, GameConstants.INPUT_MOVE_RIGHT, GameConstants.INPUT_MOVE_UP, GameConstants.INPUT_MOVE_DOWN
            );

        GD.Print("direction: " + direction);
    }

    public override void _Ready()
    {
        if (StateMachineNode == null)
        {
            GD.PrintErr("StateMachineNode is not assigned properly");
        }
    }

}
