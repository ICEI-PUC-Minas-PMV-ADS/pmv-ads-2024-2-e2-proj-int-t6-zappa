using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudapp.Model;

namespace crudapp.Data
{
    public class crudappContext : DbContext
    {
        public crudappContext (DbContextOptions<crudappContext> options)
            : base(options)
        {
        }

        public DbSet<crudapp.Model.User> User { get; set; } = default!;
    }
}
