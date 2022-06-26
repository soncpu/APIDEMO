using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Model
{
    public class DatabaseContext : DbContext
    {
        internal DbSet<User> Products { get; set; }

        public DatabaseContext() : base() { }
        public DatabaseContext(DbContextOptions options) : base(options) { }

    }
}
