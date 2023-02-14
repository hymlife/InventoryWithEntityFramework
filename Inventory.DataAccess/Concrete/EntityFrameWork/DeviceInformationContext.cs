using Inventory.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DataAccess.Concrete.EntityFrameWork
{
    public class DeviceInformationContext : DbContext
    {
        public DbSet<DeviceInformation> DeviceInformations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=db; Integrated Security=True; Encrypt=False;");
            }
        }
    }
}
