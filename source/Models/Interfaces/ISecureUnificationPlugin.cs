using IUnification.Models.Enums;
using System;

namespace IUnification.Models.Interfaces
{
    /// <summary>
    /// An interface for use in implimenting an IUnificationPlugin that requires authentication.
    /// </summary>
    public interface ISecureUnificationPlugin
    {
        /// <summary>
        /// Indicates the user authentication status of this IUnificationPlugin instance.
        /// </summary>
        AuthenticationStatus AuthenticationStatus { get; }

        /// <summary>
        /// An array of the InputFeilds required for user authentication.
        /// </summary>
        InputField[] AuthenticationFields { get; }

        /// <summary>
        /// Event to be raised when the AuthenticationStatus variable of this ISecureUnificationPlugin instance changes.
        /// </summary>
        event EventHandler<AuthenticationStatus> AuthenticationStatusChangedEvent;

        /// <summary>
        /// Method to call when requesting server-side user authentication.
        /// </summary>
        /// <param name="FieldValues">Field values required for authentication.</param>
        /// <returns>Outcome of user authentication attempt.</returns>
        bool AuthenticateUser(InputField[] FieldValues);
    }
}
