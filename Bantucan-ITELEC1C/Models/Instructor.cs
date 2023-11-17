using System.ComponentModel.DataAnnotations;

namespace Bantucan_ITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        [Required]
        public int Id { get; set; }

        [Display(Name ="First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Is Tenured")]
        public bool IsTenured { get; set; }

        [Display(Name ="Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name ="Academic rank")]
        public Rank Rank { get; set; }

        [RegularExpression("[0-9] {3}-[0-9] {3}-[0-9] {4}",
                            ErrorMessage = "you must follow the format 000-00-00")]
        [Display(Name ="Office phone number")]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        [Display(Name ="Email Address")]
        public string? EmailAddress { get; set; }

        [Url]
        [Display(Name ="Personal Webpage")]
        public string? PersonalURL { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name ="Password (we won't use this!)")]
        [DataType(DataType.Password)]
        public string UnusedPassword { get; set; }


    }
}
