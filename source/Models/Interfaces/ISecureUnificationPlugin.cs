namespace IUnification.Models.Interfaces
{
    public interface ISecureUnificationPlugin : IUnificationPlugin
    {
        /// <summary>
        /// An array of the Feilds required for user authentication.
        /// </summary>
        AuthenticationField[] AuthenticationFields { get; }

        /// <summary>
        /// Method to call when requesting server-side user authentication.
        /// </summary>
        /// <param name="FieldValues">Field values required for authentication.</param>
        /// <returns>Success of authenticatio.</returns>
        bool AuthenticateUser(AuthenticationField[] FieldValues);
    }
}
