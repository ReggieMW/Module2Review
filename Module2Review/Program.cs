namespace Module2Review;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Student michael = new Student();
        michael.Name = "Michael Doyle";
        michael.ID = 205;
        Student reggie = new Student() { Name = "Reggie Woods", ID = 206 };
        Student emily = new Student()
        {
            Name = "Emily Woods",
            ID = 207
        };
        Student mookie = new Student() { Name = "Mookie Woods", ID = 208 };

        students.Add(michael);
        students.Add(reggie);
        students.Add(emily);
        students.Add(mookie);

        michael.AddGrade(92.5);
        michael.AddGrade(92.5, 98.6, 85.3);
        emily.AddGrade(68.3);
        emily.AddGrade(99.9, 85.3, 95.2);
        mookie.AddGrade(75.4);
        mookie.AddGrade(54.4, 36.8, 78.0);
        reggie.AddGrade(99.5);
        reggie.AddGrade(98.5, 99.2, 98.7);

        foreach (var student in students)
        {
            Console.Write($"{student.Name} {student.ID}: Grades- "); 
            foreach (var grade in student.Grades)
            {
                Console.Write($"{grade}, ");
            }
            Console.Write($"Average- {student.CalculateAverageGrade()}\n");
        }
        
        Course economics = new Course();
        economics.EnrolledStudents = new List<Student>();
        economics.CourseName = "Economics";
        economics.CourseCode = "301";
        economics.AddStudent(reggie);
        economics.AddStudent(mookie);
        
        Console.WriteLine($"{economics.CourseName} {economics.CourseCode}:");
        foreach (var student in economics.EnrolledStudents)
        {
            Console.Write($"{student.Name}\n");
        }

        Console.Write("have enrolled in this course.");
    }
}