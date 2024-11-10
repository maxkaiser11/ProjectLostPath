using Godot;
using System;

public partial class PlayerIdleState : PlayerState
{
    public override void _PhysicsProcess(double delta)
    {
        if (characterNode.direction != Vector2.Zero)
        {
            characterNode.StateMachineNode.SwitchState<PlayerMoveState>();
        }
    }


    public override void _Input(InputEvent @event)
    {
        //:TODO add player attack animation
    }

    protected override void EnterState()
    {
        GD.Print("Entering Idle State");
        characterNode.Velocity = Vector2.Zero;
        characterNode.SpriteNode.Play(GameConstants.ANIM_IDLE);
    }
}
