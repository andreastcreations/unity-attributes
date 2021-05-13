using UnityEditor;
using UnityEngine;

namespace ATM.Decoration
{
    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, new GUIContent(property.displayName));
            GUI.enabled = true;
        }
    }
}
