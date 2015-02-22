using IUnification.Models.Enums;

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
        public InputField(string FieldName, FieldType FieldType)
        {
            this.FieldName = FieldName;
            this.FieldType = FieldType;
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
                        if (value.ToLowerInvariant().Equals("t") ||
                            value.ToLowerInvariant().Equals("true"))
                        {
                            _Value = "true";
                        }
                        else
                        {
                            _Value = "false";
                        }

                        break;

                    case FieldType.Sensitive:
                    case FieldType.Standard:
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
