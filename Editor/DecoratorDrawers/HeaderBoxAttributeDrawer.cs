using UnityEditor;
using UnityEngine;

namespace ATM.Decoration
{
    [CustomPropertyDrawer(typeof(HeaderBoxAttribute))]
    public class HeaderBoxAttributeDrawer : DecoratorDrawer
    {
        private HeaderBoxAttribute HBAttribute => (HeaderBoxAttribute)attribute;

        public override float GetHeight()
        {
            return EditorGUIUtility.singleLineHeight * 1.5f + HBAttribute.spaceBefore + HBAttribute.spaceAfter;
        }

        public override void OnGUI(Rect position)
        {
            Rect headerRect = new Rect(position.x,
                                       position.y + HBAttribute.spaceBefore + 1f,
                                       position.width,
                                       EditorGUIUtility.singleLineHeight * 1.3f);

            Color textColor = new Color32(226, 226, 226, 255);
            Color textureColor = new Color32(88, 88, 88, 255);

            Texture2D headerTexture = new Texture2D(1, 1);
            Color[] textureColorArray = headerTexture.GetPixels();
            for (var i = 0; i < textureColorArray.Length; ++i)
            {
                textureColorArray[i] = textureColor;
            }
            headerTexture.SetPixels(textureColorArray);
            headerTexture.Apply();

            GUIStyle headerStyle = new GUIStyle()
            {
                normal = new GUIStyleState()
                {
                    textColor = textColor,
                    background = headerTexture
                },
                border = GUI.skin.button.border,
                fontStyle = FontStyle.Bold,
                alignment = TextAnchor.MiddleCenter
            };

            EditorGUI.LabelField(headerRect, HBAttribute.header, headerStyle);
        }
    }
}
