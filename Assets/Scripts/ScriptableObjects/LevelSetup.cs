using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSetup")]
public class LevelSetup : ScriptableObject
{
    [SceneSelector] public string menuScene;
    [SceneSelector] public List<string> levelScenes = new List<string>();
}
