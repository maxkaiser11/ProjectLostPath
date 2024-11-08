using Godot;
using System;

public partial class Slot : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += OnSlotPressedSignal;
	}


	public override void _Process(double delta)
	{
		// Player can press 1 to switch Class
		if (Input.IsActionJustPressed("firstClass"))
		{
			EmitSignal("pressed");
		}
	}


	private void OnSlotPressedSignal()
	{
		GD.Print("Slot Pressed with 1");
	}
}
