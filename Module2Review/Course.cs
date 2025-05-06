namespace Module2Review;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();
    

    public void AddStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            EnrolledStudents.Add(student);
        }
    }
}