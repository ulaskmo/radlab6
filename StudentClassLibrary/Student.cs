namespace StudentClassLibrary
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }

        // Navigation Property
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}