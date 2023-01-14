using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BonayogDianaMae.Midterm.Infrastructure.Domain.Models
{
    public class Municipalities
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DateOfCharter { get; set; }
        public Type? Type{ get; set; }
        public Guid? ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public Provinces? Provinces{ get; set; }
    }

    public enum Type
    {
        Urban = 1,
        Rural = 2
    }
}