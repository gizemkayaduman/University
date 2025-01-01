namespace University.Models.Entities
{
    public class Department
    {
        public int DEPTCODE { get; set; } // Primary Key
        public string DEPTNAME { get; set; }
        public string DEPTOFFICE { get; set; }
        public string DEPTPHONE { get; set; }
        public string DEPTCOLLEGE { get; set; }

        // Navigation Properties (if any)
        public ICollection<Course> Courses { get; set; }
    }

}
