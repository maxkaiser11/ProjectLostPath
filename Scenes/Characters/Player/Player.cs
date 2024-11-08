
using Godot;

public partial class Player : CharacterBody2D
{

	[Export] private AnimatedSprite2D spriteNode;
	[Export] public float MaxSpeed = 200f;


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
			spriteNode.FlipH = true;

		}
		if (Input.IsActionPressed("right"))
		{
			direction.X += 1;
			spriteNode.Play("walk");
			spriteNode.FlipH = false;

		}

		// Normalize direction to prevent faster diagonal movement
		direction = direction.Normalized();


		// Move the player with the new velocity
		Velocity = direction * MaxSpeed;
		MoveAndSlide();
	}
}
