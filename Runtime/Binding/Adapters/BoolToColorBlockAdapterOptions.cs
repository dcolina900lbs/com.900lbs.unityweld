using UnityEngine;
using UnityEngine.UI;

namespace UnityWeld.Binding.Adapters
{
    /// <summary>
    /// Options for converting from a bool to a Unity color.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Weld/Adapter Options/Bool to ColorBlock Adapter Options")]
    public class BoolToColorBlockAdapterOptions : AdapterOptions
    {
        /// <summary>
        /// The value used when the bool is false.
        /// </summary>
        [Header("False colors")]
        public ColorBlock FalseColors;

        /// <summary>
        /// The value used when the bool is true.
        /// </summary>
        [Header("True colors")]
        public ColorBlock TrueColors;
    }
}