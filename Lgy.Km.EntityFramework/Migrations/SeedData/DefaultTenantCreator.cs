using System.Linq;
using Lgy.Km.EntityFramework;
using Lgy.Km.MultiTenancy;

namespace Lgy.Km.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly KmDbContext _context;

        public DefaultTenantCreator(KmDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
