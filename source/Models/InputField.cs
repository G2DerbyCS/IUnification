using IUnification.Models.Enums;
using System;

namespace IUnification.Models
{
    /// <summary>
    /// A class representitive of an input field.
    /// </summary>
    public class InputField
    {
        /// <summary>
        /// Stores the value of this InputField instance.
        /// </summary>
        private string _Value;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="FieldName">Field Title/Name.</param>
        /// <param name="IsSensitive">Field sensitivity.</param>
        /// <param name="Value">Content of input field, will be empty if unset.</param>
        public InputField(string FieldName, FieldType FieldType, String Value = @"")
        {
            this.FieldName = FieldName;
            this.FieldType = FieldType;
            this.Value     = Value;
        }

        /// <summary>
        /// Indicates the title to be assigned to the field in the user interface.
        /// </summary>
        public string FieldName
        {
            private set;
            get;
        }

        /// <summary>
        /// Indicates how the field should be handled in the user interface.
        /// </summary>
        public FieldType FieldType
        {
            private set;
            get;
        }

        /// <summary>
        /// Indicates the value of this InputField instance.
        /// </summary>
        public string Value
        {
            set
            {
                switch (FieldType)
                {
                    case FieldType.Boolean:
                        _Value = value.ToStringBoolean();
                        break;

                    default:
                        _Value = value;
                        break;
                }
            }

            get
            {
                return _Value;
            }
        }
    }
}
