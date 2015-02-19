using System;
using IUnification.Models.Enums;

namespace IUnification.Models.Interfaces
{
    public interface IMetadataContainer
    {
        /// <summary>
        /// Path/url to the file/stream.
        /// </summary>
        Uri  Datasource { get; }

        /// <summary>
        /// Datasource url format type, e.g stream or file.
        /// </summary>
        DatasourceFormat DatasourceFormat       { get; }

        /// <summary>
        /// Returns the value of a metadata field.
        /// </summary>
        /// <param name="MetadataField">The name of the Field value to be returned.</param>
        /// <returns>Field value</returns>
        string Metadata(string MetadataField);

        /// <summary>
        /// The names of all metadata Fields within this container.
        /// </summary>
        string[] MetadataFields { get; }
    }
}