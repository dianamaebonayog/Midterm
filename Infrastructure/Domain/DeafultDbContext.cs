using Microsoft.EntityFrameworkCore;
using BonayogDianaMae.Midterm.Infrastructure.Domain.Model;
using BonayogDianaMae.Midterm.Infrastructure.Domain.Models;
using System.Data;

namespace BonayogDianaMae.Midterm.Infrastructure.Domain
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
        : base(options)
        {

        }

        public DbSet<Provinces> Provinces { get; set; }
        protected override void OnModelCreating(ModelBuilder modeBuilder)
        {
            List<Provinces> roles = new List<CProvinces>();

            roles.Add(new Provinces()
            {
                Id = Guid.Parse("0faf41a9-d5c6-41b2-bb3b-f106a30dfed2"),
                Name = "Province",
                Description = "Province within the country",
                Abbreviation = "Prvce",
            });

            roles.Add(new Provinces()
            {      
                Id = Guid.Parse("dda07425-9084-4894-b41c-bc4f04c3a055"),
                Name = "Municipality",
                Description = "Municipality within the province",
                Abbreviation = "Mncpty",
            });

            roles.Add(new Provinces()
            {
                Id = Guid.Parse("9849e656-37cf-4569-96f8-05e6ed72ce83"),
                Name = "Barangay",
                Description = "Barangay within the municipality",
                Abbreviation = "Brgy",
            });

        }
    }
}