using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Admin_App
{
    public class AuftragsDbContext : DbContext
    {
        public DbSet<ServiceAuftrag> ServiceAufträge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DeineConnectionString");
        }
    }

}
