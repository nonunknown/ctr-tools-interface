using Godot;
using System;

public class Main : Control
{
	MenuAnim anim;
	RichTextLabel description;
	[Export]
	NodePath npDescription;
	AudioStreamPlayer snd_select, snd_back, snd_move, snd_change;

	public override void _Ready()
	{
		anim = GetNode<MenuAnim>("MenuAnim");
		description = GetNode<RichTextLabel>(npDescription);
		Paths.Initialize(true);
		snd_select = GetNode("Sound/select") as AudioStreamPlayer;
		snd_back = GetNode("Sound/back") as AudioStreamPlayer;
		snd_move = GetNode("Sound/move") as AudioStreamPlayer;
		snd_change = GetNode("Sound/change") as AudioStreamPlayer;

        if (OS.HasFeature("Windows"))
        {
            CTRFramework.Scene.ExportConfig.SetSystem(0);
        }
        else
        {
            CTRFramework.Scene.ExportConfig.SetSystem(1);
        }


    }

	 void MouseEnter()
	{

	}

	private void OnBigMouseEnter(String desc)
	{
		description.Text = desc;
		snd_move.Play();
	}


	private void OnMpkMouseEntered(String desc)
	{
		snd_move.Play();
		description.Text = desc;
		// Replace with function body.
	}


	private void OnModelsMouseEnter(String desc)
	{
		snd_move.Play();
		description.Text = desc;
		// Replace with function body.
	}


	private void OnLngMouseEnter(String desc)
	{
		snd_move.Play();
		description.Text = desc;
		// Replace with function body.
	}


	private void OnHowlMouseEnter(String desc)
	{
		snd_move.Play();
		description.Text = desc;
		// Replace with function body.
	}


	private void OnCseqMouseEnter(String desc)
	{
		snd_move.Play();
		description.Text = desc;
		// Replace with function body.
	}


	private void OnViewerMouseEnter(String desc)
	{
		snd_move.Play();
		description.Text = desc;
		// Replace with function body.
	}


	private void OnBigPressed()
	{
		anim.ChangeState((int)MenuAnim.STATE.BIG);
		snd_select.Play();
		snd_change.Play();
	}


	private void OnMpkPressed()
	{
		// Replace with function body.
	}


	private void OnBtModelsPressed()
	{
		anim.ChangeState((int)MenuAnim.STATE.MODEL);
		snd_select.Play();
		snd_change.Play();
	}


	private void OnLngPressed()
	{
		// Replace with function body.
	}


	private void OnHowlPressed()
	{
		// Replace with function body.
	}


	private void OnCseqPressed()
	{
		// Replace with function body.
	}


	private void OnViewerPressed()
	{
		// Replace with function body.
	}

	private void OnBackPressed()
	{
		anim.ChangeState(0);
		snd_back.Play();
	}


}
