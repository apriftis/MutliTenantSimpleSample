using System.Threading.Tasks;

namespace MultiTenancy.Interfaces
{
    public interface ITenantResolutionStrategy
    {
        Task<string> GetTenantIdentifierAsync();
    }
}
