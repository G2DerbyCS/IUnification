using System;

namespace IUnification.Models.Interfaces
{
    /// <summary>
    /// An interface for use in implimenting a secure IUnificationPlugin.
    /// </summary>
    public interface ISecureUnificationPlugin : IUnificationPlugin
    {
        /// <summary>
        /// Indicates if this ISecureUnificationPlugin instance has an authenticated user state.
        /// </summary>
        bool Authenticated { get; }

        /// <summary>
        /// An array of the Feilds required for user authentication.
        /// </summary>
        AuthenticationField[] AuthenticationFields { get; }

        /// <summary>
        /// Event to be raised when the Authenticated variable state of this ISecureUnificationPlugin instance changes.
        /// </summary>
        event EventHandler<bool> AuthenticationStatusChangedEvent;

        /// <summary>
        /// Method to call when requesting server-side user authentication.
        /// </summary>
        /// <param name="FieldValues">Field values required for authentication.</param>
        /// <returns>Success of authenticatio.</returns>
        bool AuthenticateUser(AuthenticationField[] FieldValues);
    }
}
