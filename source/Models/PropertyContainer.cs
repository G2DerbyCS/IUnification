using System;

namespace IUnification.Models
{
    /// <summary>
    /// A class for use with an IConfigurableUnificationPlugin instance for storing an object.
    /// </summary>
    public class PropertyContainer
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="PropertyName">Name of the property.</param>
        public PropertyContainer(string PropertyName)
        {
            this.PropertyName = PropertyName;
        }

        /// <summary>
        /// Stores the passed in Object swithin this PropertyContainer instance.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="PropertyObject">Object to save.</param>
        public void SetPropertyObject<T>(T PropertyObject)
        {
            PropertyType        = PropertyObject.GetType();
            this.PropertyObject = PropertyObject;
        }

        /// <summary>
        /// Indicates the name of the property stored within this PropertyContainer instance.
        /// </summary>
        public string PropertyName
        {
            set;
            get;
        }

        /// <summary>
        /// Accessor for the Object stored within this PropertyContainer instance.
        /// </summary>
        public Object PropertyObject
        {
            private set;
            get;
        }

        /// <summary>
        /// Indicates the Type of the Object stored within this PropertyContainer instance.
        /// </summary>
        public Type PropertyType
        {
            private set;
            get;
        }
    }
}
