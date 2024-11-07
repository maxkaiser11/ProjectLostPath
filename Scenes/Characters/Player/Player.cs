using Godot;

public partial class Player : CharacterBody2D
{
	[Export] public float Speed = 50;

	[Export] private AnimatedSprite2D spriteNode;


	public override void _PhysicsProcess(double delta)
	{

		MovePlayer();

	}

	private void MovePlayer()
	{
		Vector2 direction = Vector2.Zero;

		if (Input.IsActionPressed("up"))
		{
			direction.Y -= 1;
			spriteNode.Play("walk");
		}
		if (Input.IsActionPressed("down"))
		{
			direction.Y += 1;
			spriteNode.Play("walk");
		}
		if (Input.IsActionPressed("left"))
		{
			direction.X -= 1;
			spriteNode.Play("walk");
		}
		if (Input.IsActionPressed("right"))
		{
			direction.X += 1;
			spriteNode.Play("walk");
		}

		if (direction != Vector2.Zero)
		{
			direction = direction.Normalized();
		}


		Velocity = direction * Speed;
		MoveAndSlide();
	}
}
