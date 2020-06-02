using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataLayer.Models
{
    public partial class BlogDBContext : DbContext
    {
        public BlogDBContext()
        {
        }

        public BlogDBContext(DbContextOptions<BlogDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PageComments> PageComments { get; set; }
        public virtual DbSet<PageGroups> PageGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=Blog_db;user=root;treattinyasboolean=true", x => x.ServerVersion("8.0.20-mysql"));
            }
        }

      

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
