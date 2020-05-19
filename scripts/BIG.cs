using CliWrap;
using Godot;
using System;
using System.Diagnostics;

public class BIG : FileDialog
{
	
	TextEdit output;

	public override void _Ready() 
	{
		output = GetNode<TextEdit>("../Output");
	}
	private void _on_Big_visibility_changed()
	{
		CurrentDir = Paths.GetSourceDir();
		GD.Print(CurrentDir);

	}
	private void _on_FileDialog_file_selected(String path)
	{
		Godot.Collections.Array r = new Godot.Collections.Array();
		int err = 0;
		if (OS.GetName() == "Windows")
		{
			string[] args = new string[]{path};
			err = OS.Execute(Paths.GetToolsDir(0),args,true,r,true);
		}
		else
		{
			string[] args = new string[]{Paths.GetToolsDir(0), path};
			err = OS.Execute("wine",args,true,r,true);
		}
		
		output.Text += r.ToString();
		output.Text += "\n FINAL STATUS = "+err.ToString();
		
	}

	private void _on_FileDialog_confirmed()
	{
		GD.Print("clicked");
	}

}






