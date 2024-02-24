namespace Mission06_Valdovinos.Models
{
    public class Application
    {
        public int MovieID { get; set; } //automatically sets getters and setters READ ONLY VARIABLE
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
