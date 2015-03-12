using System;

namespace IUnification.Models
{
    /// <summary>
    /// A static class containing extension methods for system types.
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// Inspects content of string returning either a true or false lowercase string.
        /// </summary>
        /// <param name="value">String to be inspected.</param>
        /// <returns>Lowercase true or false string.</returns>
        public static String ToStringBoolean(this String value)
        {
            switch (value.ToLowerInvariant())
            {
                case "1":
                case "y":
                case "yes":
                    return "true";

                default:
                    return "false";
            }
        }
    }
}
