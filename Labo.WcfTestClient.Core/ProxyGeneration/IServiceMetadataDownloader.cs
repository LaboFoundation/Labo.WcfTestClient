using System.Collections.ObjectModel;
using System.ServiceModel.Description;

namespace Labo.WcfTestClient.Core.ProxyGeneration
{
    public interface IServiceMetadataDownloader
    {
        Collection<MetadataSection> DownloadMetadata(string wsdlUrl);
    }
}