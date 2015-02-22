namespace IUnification.Models.Interfaces
{
    /// <summary>
    /// An interface for use in implimenting an IUnificationPlugin that allows persistant configuration.
    /// </summary>
    public interface IConfigurableUnificationPlugin
    {
        /// <summary>
        /// An array of input fields to be stored in the configuration of this IConfigurableUnificationPlugin instance.
        /// </summary>
        InputField[] InputFields { set; get; }

        /// <summary>
        /// An array of properties to be stored in the configuration of this IConfigurableUnificationPlugin instance.
        /// </summary>
        PropertyContainer[] Properties { set; get; }
    }
}
