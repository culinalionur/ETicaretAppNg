using ETicaretApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
           
            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new ETicaretAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
