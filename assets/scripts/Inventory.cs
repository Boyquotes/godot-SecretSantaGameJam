using Godot;
using System;

public class Inventory : Control
{
    public override void _Process(float delta)
    {
        Global global = GetNode<Global>("/root/Global");

        Control Inventory = GetNode<Control>(".");

        Inventory.Visible = (bool)global.Get("onMenu");
    }
}
