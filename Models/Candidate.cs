using System.ComponentModel.DataAnnotations;

namespace Basics.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email is required.")]
        public String? Email { get; set; } =String.Empty;

        [Required(ErrorMessage ="First name is required.")]
        public String? FirstName { get; set; } =String.Empty;

        [Required(ErrorMessage ="Last name is required.")]
        public String? LastName { get; set; } =String.Empty;

        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";

        [Required(ErrorMessage ="Age is required.")]
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } =String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate(){
            ApplyAt = DateTime.Now;
            
        }
    }
}