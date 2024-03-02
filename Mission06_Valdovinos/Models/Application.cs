using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Valdovinos.Models
{
    public class Application
    {
        [Key]
        public int MovieID { get; set; } //automatically sets getters and setters READ ONLY VARIABLE

        [ForeignKey("CategoryID")]
        public string CategoryID { get; set; }
        public Categories Categories { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1888, 2050)]
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
