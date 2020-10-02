namespace MultiTenancy.Interfaces
{
    public interface ITenantAccessor<out T> where T : Tenant
    {
        T Tenant { get; }
    }
}
