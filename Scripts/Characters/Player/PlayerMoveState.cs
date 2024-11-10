using Godot;

public partial class PlayerMoveState : PlayerState
{
    private float speed = 150f;

    public override void _PhysicsProcess(double delta)
    {

        if (characterNode.direction == Vector2.Zero)
        {
            GD.Print("Switching to idle state");
            characterNode.StateMachineNode.SwitchState<PlayerIdleState>();
            return;
        }

        characterNode.Velocity = characterNode.direction * speed;


        characterNode.MoveAndSlide();
        characterNode.Flip();

        //Ensure move anim is playing
        characterNode.SpriteNode.Play(GameConstants.ANIM_MOVE);
    }

    protected override void EnterState()
    {
        characterNode.SpriteNode.Play(GameConstants.ANIM_MOVE);
    }
}
