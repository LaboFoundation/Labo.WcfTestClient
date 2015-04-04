namespace Labo.WcfTestClient.Core.ProxyGeneration
{
    public interface IServiceClientProxyCompiler
    {
        ServiceClientProxyCompileResult CompileProxy(ServiceMetadataInformation serviceMetadataInfo);
    }
}