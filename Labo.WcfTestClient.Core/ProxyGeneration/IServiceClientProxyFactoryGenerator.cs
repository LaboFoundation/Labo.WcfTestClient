namespace Labo.WcfTestClient.Core.ProxyGeneration
{
    internal interface IServiceClientProxyFactoryGenerator
    {
        ServiceClientProxyFactory GenerateProxyFactory(string serviceUrl);
    }
}