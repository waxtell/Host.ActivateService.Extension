using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Hosting
{
    public static class IHostExtensions
    {
        public static IHost ActivateService<TService>(this IHost host)
        {
            host.Services.GetService<TService>();

            return host;
        }
    }
}