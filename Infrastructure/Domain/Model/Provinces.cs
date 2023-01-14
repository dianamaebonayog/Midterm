using System.Diagnostics.Contracts;

namespace BonayogDianaMae.Midterm.Infrastructure.Domain.Models
{
    public class Provinces
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Abbreviation { get; set; }
    }
}