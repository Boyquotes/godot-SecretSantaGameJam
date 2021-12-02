using Godot;
using System;

public class Cursor : KinematicBody2D
{
    [Export] Vector2 Grid = new Vector2(0, 0);
    Vector2 ActualPosition = new Vector2(0, 0);
    Vector2 GridReset = new Vector2(24, 24);

    public override void _PhysicsProcess(float delta)
    {
        var global = GetNode<Global>("/root/Global");
        if (!(bool)global.Get("onMenu"))
        {
            if (Input.IsActionJustPressed("ui_right"))
            {
                Grid.x += 1;
            }
            else if (Input.IsActionJustPressed("ui_left"))
            {
                Grid.x -= 1;
            }
            else if (Input.IsActionJustPressed("ui_up"))
            {
                Grid.y -= 1;
            }
            else if (Input.IsActionJustPressed("ui_down"))
            {
                Grid.y += 1;
            }
        }

        if (Input.IsActionJustPressed("game_inv"))
        {
            global.Set("onMenu", !(bool)global.Get("onMenu"));
        }

        if (Grid.x < 0)
        {
            Grid.x = 0;
        }
        else if(Grid.x > 15)
        {
            Grid.x = 15;
        }
        else if(Grid.y < 0)
        {
            Grid.y = 0;
        }
        else if(Grid.y > 8)
        {
            Grid.y = 8;
        }

        ActualPosition.x = GridReset.x + Grid.x * 64;
        ActualPosition.y = GridReset.y + Grid.y * 64;

        Position = ActualPosition;
    }
}
