using Godot;
using System;

namespace Arpg
{
	public partial class Player : CharacterBody2D
	{
		[Export]
		public int Speed = 300;

		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
		}

		// Called every frame. 'delta' is the elapsed time since the previous frame.
		public override void _PhysicsProcess(double delta)
		{
			HandleInput();
			MoveAndSlide();
		}

		private void HandleInput()
		{
			var dir = Input.GetVector("move_left", "move_right", "move_up", "move_down");
			Velocity = dir * Speed;
		}
	}
}
