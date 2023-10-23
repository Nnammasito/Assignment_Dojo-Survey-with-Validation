#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace Assignment_Dojo_Survey_with_Validation.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2, ErrorMessage="Field should be 2 characters or greater")]
        [Display(Name="Your Name:")]
        public string Name {get;set;}
        [Required]
        [Display(Name="Your Location:")]
        public string Location {get;set;}
        [Required]
        [Display(Name="Favorite Language:")]
        public string Language {get;set;}
        [MinLength(20, ErrorMessage="Field should be 20 characters or greater")]
        [Display(Name="Leave a comment? (optional)")]
        public string? Comment {get;set;}
    }
}