using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        
        private string Path { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Path = System.IO.Path.Join(path, "contacts.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           options.UseSqlite($"Data Source={Path}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>()
                .HasData(
                    new OrganizationEntity() 
                    {
                        Id = 101,
                        Name = "WSEI",
                        Description = "Uczelnia Wyższa"
                    },
                    new OrganizationEntity()
                    {
                        Id = 102,
                        Name = "Koło studenckie VR",
                        Description = "Uczelnia Wyższa"
                    }
                );

            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { Id = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", OrganizationId = 102},
                new ContactEntity() { Id = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", OrganizationId = 101}
            );

            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Address)
                .HasData(
                new
                {
                    OrganizationEntityId = 101,
                    City = "Kraków",
                    Street = "św. Filipa 17",
                    PostalCode = "31-150"
                },
                new
                {
                    OrganizationEntityId = 102,
                    City = "Kraków",
                    Street = "św. Filipa 17, pok. 12",
                    PostalCode = "31-150"
                }
                );
        }
    }
}
