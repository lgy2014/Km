using Lgy.Km.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Lgy.Km.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly KmDbContext _context;

        public InitialHostDbBuilder(KmDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
