using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SceneSelectorAttribute))]
public class SceneSelectorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        // if property has correct type
        if (property.propertyType == SerializedPropertyType.String)
        {
            // find previous value and set to ui
            var oldScene = AssetDatabase.LoadAssetAtPath<SceneAsset>(property.stringValue);

            // set label and obj field
            var newScene = EditorGUI.ObjectField(position, label, oldScene, typeof(SceneAsset), false) as SceneAsset;

            // if ui got new value
            if (oldScene != newScene)
            {
                // get path of asset
                string scenePath = AssetDatabase.GetAssetPath(newScene);

                // set to property back
                property.stringValue = scenePath;

            }
        }
        else
        {
            // show error
            EditorGUI.HelpBox(position, "Use SceneSelector with string.", MessageType.Error);
        }

        EditorGUI.EndProperty();
    }
}
