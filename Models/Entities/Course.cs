namespace University.Models.Entities

{
    public class Course
    {
        public int CNUM { get; set; } // Primary Key
        public string CNAME { get; set; }
        public string CDESC { get; set; }
        public int CREDIT { get; set; }
        public string LEVEL { get; set; }
        public int CDEPT { get; set; }

        //public Department Department { get; set; }
    }

}
