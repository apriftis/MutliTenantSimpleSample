﻿using System.Threading.Tasks;

namespace MultiTenancy.Interfaces
{
    public interface ITenantStore<T> where T : Tenant
    {
         Task<T> GetTenantAsync(string identifier);
    }
}
