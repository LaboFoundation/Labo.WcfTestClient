using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace Labo.WcfTestClient.Core.ProxyGeneration
{
    public sealed class CSharpCodeDomProviderFactory : ICodeDomProviderFactory
    {
        public CodeDomProvider CreateProvider()
        {
            return new CSharpCodeProvider();
        }
    }
}