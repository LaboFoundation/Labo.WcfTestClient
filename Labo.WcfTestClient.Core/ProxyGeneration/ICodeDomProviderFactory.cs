using System.CodeDom.Compiler;

namespace Labo.WcfTestClient.Core.ProxyGeneration
{
    public interface ICodeDomProviderFactory
    {
        CodeDomProvider CreateProvider();
    }
}