using System;
using UnityEngine;

namespace ATM.Decoration
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class MatrixPreviewAttribute : PropertyAttribute
    {
        public MatrixPreviewAttribute()
        {

        }
    }
}
