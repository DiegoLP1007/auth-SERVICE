using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthService.Domain.Entities;

public class UserProfile
{
    [Key]
    [MaxLength(16)]
    public string Id { get; set; } = string.Empty;

    [Required]
    [MaxLength(16)]
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = string.Empty;

    // Cambia ProfilePictureUrl por ProfilePicture para que coincida con el servicio
    public string? ProfilePicture { get; set; } 

    // Agrega esta propiedad que el servicio está pidiendo
    public string? Phone { get; set; } 

    public string? Bio { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public User User { get; set; } = null!;
}