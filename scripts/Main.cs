using Godot;
using System;

public class Main : Control
{
	MenuAnim anim;
	RichTextLabel description;
	[Export]
	NodePath npDescription;
	public override void _Ready()
	{
		anim = GetNode<MenuAnim>("MenuAnim");
		description = GetNode<RichTextLabel>(npDescription);
		Paths.Initialize(true);
	}

	private void OnBigMouseEnter(String desc)
	{
		description.Text = desc;
	}


	private void OnMpkMouseEntered(String desc)
	{
		description.Text = desc;
		// Replace with function body.
	}


	private void OnModelsMouseEnter(String desc)
	{
		description.Text = desc;
		// Replace with function body.
	}


	private void OnLngMouseEnter(String desc)
	{
		description.Text = desc;
		// Replace with function body.
	}


	private void OnHowlMouseEnter(String desc)
	{
		description.Text = desc;
		// Replace with function body.
	}


	private void OnCseqMouseEnter(String desc)
	{
		description.Text = desc;
		// Replace with function body.
	}


	private void OnViewerMouseEnter(String desc)
	{
		description.Text = desc;
		// Replace with function body.
	}


	private void OnBigPressed()
	{
		anim.ChangeState((int)MenuAnim.STATE.BIG);
	}


	private void OnMpkPressed()
	{
		// Replace with function body.
	}


	private void OnModelsPressed()
	{
		// Replace with function body.
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
	}


}


