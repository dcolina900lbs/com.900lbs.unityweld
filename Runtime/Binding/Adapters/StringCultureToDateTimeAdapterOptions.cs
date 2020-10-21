using UnityEngine;

namespace UnityWeld.Binding.Adapters
{
    /// <summary>
    /// Options for converting from a string to a DateTime using format from a specified
    /// culture.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Weld/Adapter Options/String with Culture Specifier to DateTime Adapter")]
    public class StringCultureToDateTimeAdapterOptions : AdapterOptions
    {
        public string CultureName;
    }
}
