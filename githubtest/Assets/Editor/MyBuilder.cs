using UnityEngine;
using UnityEditor;
using System.Collections;

public class MyBuilder
{
	[UnityEditor.MenuItem("Tools/Build Project AllScene")]
	public static void BuildProjectAllScene()
	{
		EditorUserBuildSettings.SwitchActiveBuildTarget( BuildTarget.WebPlayer );

		string[]	allScene= new string[ EditorBuildSettings.scenes.Length ];

		int		i = 0;

		foreach( EditorBuildSettingsScene scene in EditorBuildSettings.scenes )
		{
			allScene[ i ]= scene.path;
			i++;
		}

		BuildPipeline.BuildPlayer	(
										allScene,
										"WebPlayer",
										BuildTarget.WebPlayer,
										BuildOptions.None
									);
	}
}