using System;
using IUnification.Models.Enums;

namespace IUnification.Models.Interfaces
{
    public interface IMetadataContainer
    {
        Uri              Datasource             { get; }
        DatasourceFormat DatasourceFormat       { get; }
        string[]         MetadataFields         { get; }

        string   Metadata(string MetadataFeild);
    }
}