using Microsoft.AspNetCore.Http;
using MultiTenancy.Interfaces;
using System.Threading.Tasks;

namespace MultiTenancy
{
    public class HostResolutionStrategy : ITenantResolutionStrategy
    {

        private readonly IHttpContextAccessor httpContextAccessor;
        public HostResolutionStrategy(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        
        public async Task<string> GetTenantIdentifierAsync()
        {
            return await Task.FromResult(httpContextAccessor.HttpContext.Request.Host.Host);
        }
    }
}
