using System;
using UnityEngine;

namespace ATM.Decoration
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class SliderBarAttribute : PropertyAttribute
    {
        public readonly float min;
        public readonly float max;
        public readonly byte r;
        public readonly byte g;
        public readonly byte b;
        public readonly bool hasLabel;
        public readonly float labelWidth;
        public readonly string displayName;

        public SliderBarAttribute(float min, float max, byte r, byte g, byte b,
                                    bool hasLabel = true, float labelWidth = 0, string displayName = "")
        {
            min = Mathf.Clamp(min, float.MinValue, float.MaxValue);
            max = Mathf.Clamp(max, float.MinValue, float.MaxValue);

            this.min = min;
            this.max = max;
            this.r = r;
            this.g = g;
            this.b = b;
            this.hasLabel = hasLabel;

            if (hasLabel && labelWidth <= 0)
            {
                labelWidth = UnityEditor.EditorGUIUtility.labelWidth;
            }
            this.labelWidth = (hasLabel) ? labelWidth : 0;
            this.displayName = displayName;
        }
    }
}
