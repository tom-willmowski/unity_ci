using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    [MenuItem("Build Tools/Build")]
    public static void Build()
    {
        var buildOptions = BuildOptions.Development;
        var report = BuildPipeline.BuildPlayer(
            EditorBuildSettings.scenes, 
            "test.apk", 
            BuildTarget.Android,
            buildOptions);
        EditorApplication.Exit(report.summary.result == BuildResult.Succeeded ? 0 : 1);
    }
}
