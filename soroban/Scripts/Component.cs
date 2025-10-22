using Godot;
using System;

namespace Soroban.Scripts;

public partial class Component : Sprite2D
{
    [Export(PropertyHint.Range, "1,5,1")]
    public int CompoenentValue = 1;

    private void _GetClickComponent(InputEvent @event)
    {
        // if (@event is not Input)
    }

    public override void _Input(InputEvent @event)
    {
        if (@event is not InputEventMouseButton inputEventMouse) return;
        if (!inputEventMouse.Pressed || inputEventMouse.ButtonIndex != MouseButton.Left) return;
        if (GetRect().HasPoint(ToLocal(inputEventMouse.Position)))
        {
            GD.Print("A click!");
        }
    }

    public override void _Ready()
    {
        base._Ready();
        GD.Print($"{this.CompoenentValue}");
    }

    public override void _Process(double delta)
    {
        base._Process(delta);
    }
}

