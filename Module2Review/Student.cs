namespace Module2Review;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades = new List<double>();

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrades(double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        else
        {
            return Grades.Average();
        }
        
    }
}