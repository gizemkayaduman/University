namespace University.Models.Entities
{
    public class Section
    {
        public int SECCOURSE { get; set; }  // Foreign Key
        public int SECNUM { get; set; }  // Primary Key
        public string SEMESTER { get; set; }
        public int YEAR { get; set; }
        public string INSTRUCTORNAME { get; set; }

        public Course Course { get; set; }  // Navigation Property
    }
}
