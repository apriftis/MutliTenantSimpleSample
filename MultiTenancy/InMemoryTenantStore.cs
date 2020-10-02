using MultiTenancy.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTenancy
{
    public class InMemoryTenantStore : ITenantStore<Tenant>
    {
        /// <summary>
        /// Get a tenant for a given identifier
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public async Task<Tenant> GetTenantAsync(string identifier)
        {
            var tenant = new[]
            {
                new Tenant 
                { 
                    Id = "alex-80fdb3c0-5888-4295-bf40-ebee0e3cd8f3", 
                    Identifier = "alex.my-rsv.com" 
                },
                 new Tenant
                {
                    Id = "tns-80fdb3c0-5888-4295-bf40-ebee0e3cd8f3",
                    Identifier = "tns.my-rsv.com"
                },
                  new Tenant
                {
                    Id = "base-80fdb3c0-5888-4295-bf40-ebee0e3cd8f3",
                    Identifier = "my-rsv.com"
                }
            }
            .SingleOrDefault(t => t.Identifier == identifier);

            return await Task.FromResult(tenant);
        }
    }
}
