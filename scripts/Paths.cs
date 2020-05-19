using Godot;

public static class Paths
{
	private static string path = "";
	public static void Initialize(bool isDev=true) {
		if (isDev) {
			path = ProjectSettings.GlobalizePath("res://")+"CTR/";
		}
		else {
			path = OS.GetExecutablePath()+"CTR/";
		}
	}

	public static string GetDir() {
		return path;
	}

	public static string GetSourceDir() {
		return path+"src/";
	}

	public static string GetViewerDir() {
		return path+"viewer/";
	}

	public static string GetToolsDir(int toolID = -1) {
		string toolName = "";

		switch(toolID)
		{

			case 0:
				toolName = "bigtool.exe";
				break;

			default: break;
		}

		return path+"tools/"+toolName;
	}

}
