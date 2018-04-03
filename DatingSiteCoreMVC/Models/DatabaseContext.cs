using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingSiteCoreMVC.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<Picture> Pictures { get; set; }

    }
}
