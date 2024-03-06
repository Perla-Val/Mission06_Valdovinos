using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Valdovinos.Models
{
    public class Application
    {
        [Key]
        public int MovieId { get; set; } //automatically sets getters and setters READ ONLY VARIABLE

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
        [Required(ErrorMessage = "Sorry, you need to add a Title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Sorry, you need to add a year.")]
        [Range(1888, 2050)]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required (ErrorMessage ="Sorry, you need to add if it was edited.")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }  
        public string? Notes { get; set; }
    }
}
