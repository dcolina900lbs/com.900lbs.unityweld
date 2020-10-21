﻿using UnityEngine;

namespace UnityWeld.Binding.Adapters
{
    /// <summary>
    /// Options for the float to string adapter.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Weld/Adapter Options/Float to String Adapter")]
    public class FloatToStringAdapterOptions : AdapterOptions
    {
        /// <summary>
        /// Options passed in to the Single.ToString() method.
        /// Defaults to two decimal places.
        /// See this page for more details: https://msdn.microsoft.com/en-us/library/f71z6k0c(v=vs.110).aspx
        /// </summary>
        public string Format = "0.00";
    }
}