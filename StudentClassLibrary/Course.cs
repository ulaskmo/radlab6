namespace StudentClassLibrary
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string LecturerName { get; set; }

        // Navigation Property
        public List<Student> Students { get; set; } = new List<Student>();
    }
}