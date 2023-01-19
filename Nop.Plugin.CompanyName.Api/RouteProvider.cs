using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.CompanyName.Api
{
    public class RouteProvider : IRouteProvider
    {
        // TODO: Research the precise behavior of this.
        public int Priority => 0;

        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            // Register routes here.
        }
    }
}
