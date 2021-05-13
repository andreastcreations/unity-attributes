using System;
using UnityEngine;

namespace ATM.Decoration
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class ArrayAsPopupAttribute : PropertyAttribute
    {
        public readonly string[] array;
        public readonly bool hasLabel;
        public readonly float labelWidth;
        public readonly string displayName;

        public ArrayAsPopupAttribute(string[] array,
                                     bool hasLabel = true, float labelWidth = 0, string displayName = "")
        {
            this.array = array;
            this.hasLabel = true;

            if (hasLabel && labelWidth <= 0)
            {
                labelWidth = UnityEditor.EditorGUIUtility.labelWidth;
            }
            this.labelWidth = (hasLabel) ? labelWidth : 0;
            this.displayName = displayName;
        }
    }
}
