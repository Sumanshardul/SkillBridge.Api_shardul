using System.ComponentModel.DataAnnotations;
using System.Data;
namespace SkillBridge.Api.Entities
{
    public class User
    {
        [Required,Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DataSetDateTime createdAt { get; set; }
}