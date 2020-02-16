using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sekoya.DAL
{
    public partial class SEKOYAContext : DbContext
    {
        public SEKOYAContext()
        {
        }

        public SEKOYAContext(DbContextOptions<SEKOYAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Issue> Issue { get; set; }
        public virtual DbSet<Log> Log { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=SEKOYA;Trusted_Connection=True;");
            }
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.TableName).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });
        }
    }
}
