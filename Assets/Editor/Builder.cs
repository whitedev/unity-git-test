using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class Builder {

    [UnityEditor.MenuItem("Tools/Build for Android")]
    public static void BuildForAndroid() {

        EditorUserBuildSettings.SwitchActiveBuildTarget( BuildTarget.Android );

        List<string> allScenes = new List<string>();
        foreach( EditorBuildSettingsScene scene in EditorBuildSettings.scenes ){
            if (scene.enabled) {
                allScenes.Add (scene.path);
            }
        }   

//        PlayerSettings.bundleIdentifier = "com.unity.app";
//        PlayerSettings.statusBarHidden = true;
        PlayerSettings.keystorePass = "ttt12345";
        PlayerSettings.keyaliasPass = "ttt12345";
        BuildPipeline.BuildPlayer( 
            allScenes.ToArray(),
            "app.apk",
            BuildTarget.Android,
            BuildOptions.None
        );
    }
}
