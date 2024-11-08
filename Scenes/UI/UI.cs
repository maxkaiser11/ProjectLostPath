using Godot;
using System;

public partial class UI : CanvasLayer
{
	[Export] private TextureButton _slot;
	[Export] private AnimatedSprite2D _player;

	private AnimatedSprite2D _sprite;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		_slot.Pressed += OnSlotPressedSignal;
	}


	private void OnSlotPressedSignal()
	{
		GD.Print("Signal Accessed");
		_player.Play("warriorWalk");
	}

}
