using Godot;

public abstract partial class Character : CharacterBody2D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimatedSprite2D SpriteNode { get; private set; }
    [Export] public StateMachine StateMachineNode { get; private set; }

    public Vector2 direction = new();

    public void Flip()
    {
        bool isMovingLeft = Velocity.X < 0;
        SpriteNode.FlipH = isMovingLeft;
    }
}
