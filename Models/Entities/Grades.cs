namespace University.Models.Entities
{
    public class Grades
    {
        public int SECCOURSE { get; set; }  // Foreign Key
        public int SECNUM { get; set; }  // Foreign Key
        public string SEMESTER { get; set; }
        public int YEAR { get; set; }
        public int SNUM { get; set; }  // Foreign Key
        public string GRADE { get; set; }

        public Section Section { get; set; }  // Navigation Property
        public Student Student { get; set; }  // Navigation Property
    }
}
