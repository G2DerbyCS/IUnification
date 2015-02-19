namespace IUnification.Models
{
    /// <summary>
    /// A class representitive of an authentication field.
    /// </summary>
    public class AuthenticationField
    {
        /// <summary>
        /// Stores the value of this AuthenticationField instance.
        /// </summary>
        private string _Value;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="FieldName">Field Title/Name.</param>
        /// <param name="IsSensitive">Field sensitivity.</param>
        internal AuthenticationField(string FieldName, bool IsSensitive)
        {
            this.FieldName = FieldName;
            Sensitive      = IsSensitive;
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
        /// Indicates if the content of the field should be considered as sensitive.
        /// </summary>
        public bool Sensitive
        {
            private set;
            get;
        }

        /// <summary>
        /// Indicates the value of this AuthenticationField instance.
        /// </summary>
        public string Value
        {
            set
            {
                _Value = value;
            }

            get
            {
                return _Value;
            }
        }
    }
}
