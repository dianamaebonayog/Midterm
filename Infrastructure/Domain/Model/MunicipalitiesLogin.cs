namespace EFCoreForRazorPages.Infrastructure.Domain.Models
{
    public class UserLogin
    {
        public Guid? Id { get; set; }
        public Guid? MunicipalitiesId { get; set; }
        public string? Type { get; set; } //Urban, Rural
        public string? Key { get; set; }
        public string? Value { get; set; }
    }

}