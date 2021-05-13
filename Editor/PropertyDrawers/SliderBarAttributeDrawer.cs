using UnityEditor;
using UnityEngine;

namespace ATM.Decoration
{
    [CustomPropertyDrawer(typeof(SliderBarAttribute))]
    public class SliderBarAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType != SerializedPropertyType.Float &&
                property.propertyType != SerializedPropertyType.Integer)
            {
                EditorGUI.LabelField(position, label.text, "Use ProgressBar with float or int.");
                return;
            }

            SliderBarAttribute progressBarAttribute = (SliderBarAttribute)attribute;
            float labelWidth = (progressBarAttribute.hasLabel) ? progressBarAttribute.labelWidth : 0f;
            string displayName = (progressBarAttribute.displayName == "") ? property.displayName : progressBarAttribute.displayName;

            Rect labelRect = new Rect(position.x, position.y, labelWidth, position.height);
            Rect valueRect = new Rect(EditorGUIUtility.currentViewWidth - 55f, position.y, 50f, position.height);
            Rect progressBarOutterRect = new Rect(position.x + labelRect.width + 2f,
                                                  position.y,
                                                  position.width - labelRect.width - valueRect.width - 5f,
                                                  position.height);
            Rect progressBarRect = new Rect(progressBarOutterRect.position.x + 1f,
                                            progressBarOutterRect.position.y + 1f,
                                            progressBarOutterRect.width - 2f,
                                            progressBarOutterRect.height - 2f);

            GUIStyle barStyle = new GUIStyle();
            barStyle.normal.background = GetColorTexture(new Color32(42, 42, 42, 255));
            GUIStyle sliderThumb = new GUIStyle();
            sliderThumb.normal.background = GetColorTexture(new Color32(0, 0, 0, 0));

            EditorGUI.LabelField(labelRect, displayName);
            EditorGUI.DrawRect(progressBarOutterRect, new Color32(33, 33, 33, 255));

            Color progressBarColor = new Color32(progressBarAttribute.r, progressBarAttribute.g, progressBarAttribute.b, 255);
            float progressBarValue = (property.propertyType == SerializedPropertyType.Float) ? property.floatValue : property.intValue;
            float progressBarRange = Mathf.Abs(progressBarAttribute.max - progressBarAttribute.min);

            EditorGUI.BeginChangeCheck();
            progressBarValue = GUI.Slider(progressBarRect, progressBarValue, 0,
                                          progressBarAttribute.min, progressBarAttribute.max,
                                          barStyle, sliderThumb,
                                          true, 0);
            if (EditorGUI.EndChangeCheck())
            {
                progressBarValue = Mathf.Clamp(progressBarValue, progressBarAttribute.min, progressBarAttribute.max);
            }

            Rect progressSoFarRect = new Rect(progressBarRect.x,
                                              progressBarRect.y,
                                              progressBarValue * progressBarRect.width / progressBarRange,
                                              progressBarRect.height);

            EditorGUI.DrawRect(progressSoFarRect, progressBarColor);

            if (property.propertyType == SerializedPropertyType.Float)
            {
                progressBarValue = Mathf.Round(progressBarValue * 1000f) / 1000f;
                property.floatValue = progressBarValue;
                property.floatValue = EditorGUI.FloatField(valueRect, property.floatValue);
            }
            else if (property.propertyType == SerializedPropertyType.Integer)
            {
                property.intValue = (int)progressBarValue;
                property.intValue = EditorGUI.IntField(valueRect, property.intValue);
            }
        }

        private Texture2D GetColorTexture(Color color)
        {
            Texture2D texture = new Texture2D(1, 1);
            Color[] textureColorArray = texture.GetPixels();
            for (var i = 0; i < textureColorArray.Length; ++i)
            {
                textureColorArray[i] = color;
            }
            texture.SetPixels(textureColorArray);
            texture.Apply();

            return texture;
        }
    }
}
