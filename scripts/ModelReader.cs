using CTRFramework;
using CTRFramework.Shared;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using Godot;

public class ModelReader : FileDialog
{

	private void OnFileSelected(String path)
	{
		string p = ProjectSettings.GlobalizePath(path);
		ConvertFile(p);
	}

	void ConvertFile(string path)
	{
		string ext = System.IO.Path.GetExtension(path);
		GD.Print(ext);
		switch (ext)
		{
			case ".lev":
				{
                    GD.Print(path);

                        Scene scn = Scene.FromFile(path);


                        scn.quads = scn.quads.OrderBy(o => o.id).ToList();
                        string objfile = scn.Export("obj", Detail.Low, false, false);
                        objfile = scn.Export("obj", Detail.Med, true, true);
                        //LaunchMeshLab(objfile);
                    
                    break;
				}
			case ".ctr":
				{
					LODModel mod = new LODModel(path);

					foreach (LODHeader lh in mod.lh)
						Helpers.WriteToFile(".\\" + mod.name + "_" + lh.name + ".obj", lh.ToObj());

					break;
				}

		}
		Console.WriteLine("Done!");
	}
}



