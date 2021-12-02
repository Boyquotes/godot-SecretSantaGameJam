using Godot;
using System;

public class BlocksN : RichTextLabel
{
    [Export] int[] Materials = new int[2];
    public override void _Ready()
    {
        Global global = GetNode<Global>("/root/Global");

        RichTextLabel TextLabel = GetNode<RichTextLabel>(".");
         Materials = (int[])global.Get("Materials");

        TextLabel.Text = Materials[0].ToString();
    }
}
