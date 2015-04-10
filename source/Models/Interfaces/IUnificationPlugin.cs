using IUnification.Models.Enums;
using System;
using System.ComponentModel;

namespace IUnification.Models.Interfaces
{
    /// <summary>
    /// An interface for use in creating media-providing plugins for the Unification media player.
    /// </summary>
    public interface IUnificationPlugin : IDisposable
    {
        /// <summary>
        /// Plugin Author.
        /// </summary>
        string Author { get; }

        /// <summary>
        /// The metadata collection presented by this plugin.
        /// </summary>
        BindingList<IMetadataContainer> MetadataCollection { get; }

        /// <summary>
        /// Event to be raised once the plugin has finished updating it's metadata collection.
        /// </summary>
        event EventHandler<LoadingCompletedEventArgs> MetadataCollectionUpdatedEvent;

        /// <summary>
        /// Plugin Name/Title.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Plugin version number/string.
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Requests the plugin to updated it's metadata collection.
        /// </summary>
        void UpdateMetadataCollection();
    }
}
