using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadingData.Entitties;
using Microsoft.EntityFrameworkCore;

namespace LoadingData
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogUser> BlogUsers { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("data source=db.db")
                .LogTo(Console.WriteLine)
                .UseLazyLoadingProxies();
        }
    }
}
