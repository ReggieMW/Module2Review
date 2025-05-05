namespace Module2Review;

class Program
{
    static void Main(string[] args)
    {
        List<string> students = new List<string>();
        
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

        students.Add(michael.Name); 
        students.Add(reggie.Name);
        students.Add(emily.Name);
        students.Add(mookie.Name);
        
        
    }
}