using Godot;
using System;
using System.Collections.Generic;

public class MenuAnim : Node
{
	public enum STATE {MAIN,BIG,MODEL}
	List<Node> controls = new List<Node>();
	Control state;
	public override void _Ready()
	{
		controls.Add(GetNode<Control>("../Principal"));
		controls.Add(GetNode<Control>("../Big"));
        controls.Add(GetNode<Control>("../MReader"));

		state = (Control)controls[0];
	}

	public async void ChangeState(int newState)
	{

		int value = -740;
		while(true) {
			Vector2 pos = state.RectPosition;
			Vector2 minus = new Vector2(50,0);
			state.SetPosition(pos - minus);

			if (pos.x <= value)
			{
				if (value == 0)
				{
					state.RectPosition = Vector2.Zero;
					break;
				}

				state.Visible = false;
				state = (Control)controls[(int)newState];
				GetChild<TextureButton>(0).Visible = (newState==0)?false:true;
				
				state.RectPosition = new Vector2(800,0);
				state.Visible = true;
				// FileDialog fd = state.GetChild(0) as FileDialog;
				// fd.Visible = true;
				value = 0;
			}

			await ToSignal(GetTree(),"idle_frame");
		}



		GD.Print("Done");
	}

}
