using System.Collections.ObjectModel;
using System.ServiceModel.Description;

namespace Labo.WcfTestClient.Core.ProxyGeneration
{
    public interface IServiceMetadataImporter
    {
        ServiceMetadataInformation ImportMetadata(Collection<MetadataSection> metadataCollection, MetadataImporterSerializerFormatMode formatMode);
    }
}