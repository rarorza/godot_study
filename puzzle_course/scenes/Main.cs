using Godot;
using System;

namespace Game;

public partial class Main : Node2D
{
	private Sprite2D sprite;

	public override void _Ready()
	{
		sprite = GetNode<Sprite2D>("Cursor");
	}

	public override void _Process(double delta)
	{
		// This method is called every frame
		var tileSize = 64;
		var mousePosition = GetGlobalMousePosition();
		var gridPosition = mousePosition / tileSize;
		gridPosition = gridPosition.Floor();
		sprite.GlobalPosition = gridPosition * tileSize;
	}

}
