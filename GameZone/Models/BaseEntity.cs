
namespace GameZone.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public String Name { get; set; } = string.Empty;
    }
}
