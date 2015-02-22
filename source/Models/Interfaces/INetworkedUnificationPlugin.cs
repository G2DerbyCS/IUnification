using IUnification.Models.Enums;
using System;

namespace IUnification.Models.Interfaces
{
    /// <summary>
    /// An interface for use in implimentation of a Unification plugin with network dependancy.
    /// </summary>
    public interface INetworkedUnificationPlugin
    {
        /// <summary>
        /// Indicates this INetworkedUnificationPlugin instance's connection status.
        /// </summary>
        ConnectionStatus ConnectionStatus { get; }

        /// <summary>
        /// Event to be raised when the plugin to server connection status changes.
        /// </summary>
        event EventHandler<ConnectionStatus> ConnectionStatusChangedEvent;
    }
}
