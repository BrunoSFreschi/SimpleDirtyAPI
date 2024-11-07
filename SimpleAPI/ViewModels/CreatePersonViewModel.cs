using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.ViewModels;

public class CreatePersonViewModel
{
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Phone { get; set; }
    [Required]
    public required string Adress { get; set; }
}