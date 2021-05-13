using UnityEditor;
using UnityEngine;

namespace ATM.Decoration
{
    [CustomPropertyDrawer(typeof(MatrixPreviewAttribute))]
    public class MatrixPreviewAttributeDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * 5.6f;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.type != "Matrix4x4f")
            {
                EditorGUI.LabelField(position, label.text, "Use MatrixPreview with Matrix4x4.");
                return;
            }

            SerializedProperty r00 = property.FindPropertyRelative("e00");
            SerializedProperty r01 = property.FindPropertyRelative("e01");
            SerializedProperty r02 = property.FindPropertyRelative("e02");
            SerializedProperty r03 = property.FindPropertyRelative("e03");

            SerializedProperty r10 = property.FindPropertyRelative("e10");
            SerializedProperty r11 = property.FindPropertyRelative("e11");
            SerializedProperty r12 = property.FindPropertyRelative("e12");
            SerializedProperty r13 = property.FindPropertyRelative("e13");

            SerializedProperty r20 = property.FindPropertyRelative("e20");
            SerializedProperty r21 = property.FindPropertyRelative("e21");
            SerializedProperty r22 = property.FindPropertyRelative("e22");
            SerializedProperty r23 = property.FindPropertyRelative("e23");

            SerializedProperty r30 = property.FindPropertyRelative("e30");
            SerializedProperty r31 = property.FindPropertyRelative("e31");
            SerializedProperty r32 = property.FindPropertyRelative("e32");
            SerializedProperty r33 = property.FindPropertyRelative("e33");

            float widthDivBy5 = position.width / 5;
            float height = EditorGUIUtility.singleLineHeight;

            Rect labelSize = new Rect(position.x, position.y, position.width, height);

            Rect xSize = new Rect(position.x, position.y + 20, widthDivBy5 - 2f, height);
            Rect r00size = new Rect(position.x + widthDivBy5, position.y + 20, widthDivBy5 - 2f, height);
            Rect r01size = new Rect(position.x + 2 * widthDivBy5, position.y + 20, widthDivBy5 - 2f, height);
            Rect r02size = new Rect(position.x + 3 * widthDivBy5, position.y + 20, widthDivBy5 - 2f, height);
            Rect r03size = new Rect(position.x + 4 * widthDivBy5, position.y + 20, widthDivBy5 - 2f, height);

            Rect ySize = new Rect(position.x, position.y + 40, widthDivBy5 - 2f, height);
            Rect r10size = new Rect(position.x + widthDivBy5, position.y + 40, widthDivBy5 - 2f, height);
            Rect r11size = new Rect(position.x + 2 * widthDivBy5, position.y + 40, widthDivBy5 - 2f, height);
            Rect r12size = new Rect(position.x + 3 * widthDivBy5, position.y + 40, widthDivBy5 - 2f, height);
            Rect r13size = new Rect(position.x + 4 * widthDivBy5, position.y + 40, widthDivBy5 - 2f, height);

            Rect zSize = new Rect(position.x, position.y + 60, widthDivBy5 - 2f, height);
            Rect r20size = new Rect(position.x + widthDivBy5, position.y + 60, widthDivBy5 - 2f, height);
            Rect r21size = new Rect(position.x + 2 * widthDivBy5, position.y + 60, widthDivBy5 - 2f, height);
            Rect r22size = new Rect(position.x + 3 * widthDivBy5, position.y + 60, widthDivBy5 - 2f, height);
            Rect r23size = new Rect(position.x + 4 * widthDivBy5, position.y + 60, widthDivBy5 - 2f, height);

            Rect wSize = new Rect(position.x, position.y + 80, widthDivBy5 - 2f, height);
            Rect r30size = new Rect(position.x + widthDivBy5, position.y + 80, widthDivBy5 - 2f, height);
            Rect r31size = new Rect(position.x + 2 * widthDivBy5, position.y + 80, widthDivBy5 - 2f, height);
            Rect r32size = new Rect(position.x + 3 * widthDivBy5, position.y + 80, widthDivBy5 - 2f, height);
            Rect r33size = new Rect(position.x + 4 * widthDivBy5, position.y + 80, widthDivBy5 - 2f, height);

            EditorGUI.LabelField(labelSize, new GUIContent(property.displayName));

            EditorGUI.LabelField(xSize, new GUIContent("X"));
            EditorGUI.PropertyField(r00size, r00, GUIContent.none);
            EditorGUI.PropertyField(r01size, r01, GUIContent.none);
            EditorGUI.PropertyField(r02size, r02, GUIContent.none);
            EditorGUI.PropertyField(r03size, r03, GUIContent.none);

            EditorGUI.LabelField(ySize, new GUIContent("Y"));
            EditorGUI.PropertyField(r10size, r10, GUIContent.none);
            EditorGUI.PropertyField(r11size, r11, GUIContent.none);
            EditorGUI.PropertyField(r12size, r12, GUIContent.none);
            EditorGUI.PropertyField(r13size, r13, GUIContent.none);

            EditorGUI.LabelField(zSize, new GUIContent("Z"));
            EditorGUI.PropertyField(r20size, r20, GUIContent.none);
            EditorGUI.PropertyField(r21size, r21, GUIContent.none);
            EditorGUI.PropertyField(r22size, r22, GUIContent.none);
            EditorGUI.PropertyField(r23size, r23, GUIContent.none);

            EditorGUI.LabelField(wSize, new GUIContent("W"));
            EditorGUI.PropertyField(r30size, r30, GUIContent.none);
            EditorGUI.PropertyField(r31size, r31, GUIContent.none);
            EditorGUI.PropertyField(r32size, r32, GUIContent.none);
            EditorGUI.PropertyField(r33size, r33, GUIContent.none);
        }
    }
}
