using IUnification.Models.Enums;
using System;
using System.Collections.Generic;

namespace IUnification.Models.Interfaces
{
    public interface IUnificationPlugin
    {
        event EventHandler<bool> MetadataCollectionUpdatedEvent;

        string Author     { get; }
        string Title      { get; }
        string Version    { get; }

        void UpdateMetadataCollection();
    }
}
