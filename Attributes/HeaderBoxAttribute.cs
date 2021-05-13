using System;
using UnityEngine;

namespace ATM.Decoration
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class HeaderBoxAttribute : PropertyAttribute
    {
        public readonly string header;

        public HeaderBoxAttribute(string header)
        {
            this.header = header;
        }
    }
}
