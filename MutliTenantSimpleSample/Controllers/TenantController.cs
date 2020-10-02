using Microsoft.AspNetCore.Mvc;
using MultiTenancy;
using MultiTenancy.Interfaces;
using System.Threading.Tasks;

namespace MutliTenantSimpleSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TenantController : ControllerBase
    {
        private readonly ITenantAccessor<Tenant> tenantAccessor;

        public TenantController(ITenantAccessor<Tenant> tenantAccessor)
        {
            this.tenantAccessor = tenantAccessor;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            var t = tenantAccessor.Tenant;
            var t2 = HttpContext.GetTenant();
            return await Task.FromResult(HttpContext.GetTenant().Id);
        }
    }
}
