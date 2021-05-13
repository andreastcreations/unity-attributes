using System;
using UnityEngine;

namespace ATM.Decoration
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class HeaderBoxAttribute : PropertyAttribute
    {
        public readonly string header;
        public readonly float spaceBefore;
        public readonly float spaceAfter;

        public HeaderBoxAttribute(string header,
                                  float spaceBefore = 0f, float spaceAfter = 0f)
        {
            this.header = header;

            spaceBefore = Mathf.Clamp(spaceBefore, 0f, float.MaxValue);
            spaceAfter = Mathf.Clamp(spaceAfter, 0f, float.MaxValue);
            this.spaceBefore = spaceBefore;
            this.spaceAfter = spaceAfter;
        }
    }
}
