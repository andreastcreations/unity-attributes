using UnityEditor;
using UnityEngine;

namespace ATM.Decoration
{
    [CustomPropertyDrawer(typeof(ArrayAsPopupAttribute))]
    public class ArrayAsPopupAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType != SerializedPropertyType.Integer)
            {
                EditorGUI.LabelField(position, label.text, "Use ArrayAsPopup with int.");
                return;
            }

            ArrayAsPopupAttribute arrayAsPopupAttribute = (ArrayAsPopupAttribute)attribute;

            if (arrayAsPopupAttribute.hasLabel)
            {
                Rect labelRect = new Rect(position.x, position.y, arrayAsPopupAttribute.labelWidth, position.height);
                Rect popUpRect = new Rect(position.x + labelRect.width + 2f, position.y, position.width - labelRect.width, position.height);

                string displayName = (arrayAsPopupAttribute.displayName == "") ? property.displayName : arrayAsPopupAttribute.displayName;

                EditorGUI.LabelField(labelRect, displayName);
                property.intValue = EditorGUI.Popup(popUpRect, property.intValue, arrayAsPopupAttribute.array);
            }
            else
            {
                property.intValue = EditorGUI.Popup(position, property.intValue, arrayAsPopupAttribute.array);
            }
        }
    }
}
