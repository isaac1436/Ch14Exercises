public class Student
{
    public string fullName { get; set; }
    public string course { get; set; }
    public enum subjects { Maths, CSharp, Java, Flutter, WebDev, Python }
    public string university { get; set; }
    public string email { get; set; }
    public string phoneNum { get; set; }

    static int countObjs;

    public Student()
    {
        new Student(this.fullName, this.course, this.university);
    }
    public Student(string? name = null, string? course = null, string? uni = null)
    {
        this.fullName = name;
        this.course = course;
        this.university = uni;
        new Student(this.email, this.phoneNum);
    }

    public Student(string? mail = null, string? num = null)
    {
        this.email = mail;
        this.phoneNum = num;
    }

    public void showInfo(Student student)
    {
        Console.WriteLine("Full Name : \t \t{0}", this.fullName);
        Console.WriteLine("University : \t \t{0}", this.university);
        Console.WriteLine("Course of Study : \t{0}", this.course);
        Console.WriteLine("Phone No : \t \t{0}", this.phoneNum);
        Console.WriteLine("E-mail : \t \t{0}", this.email);
        Console.Write("Courses: ");


        string[] subj ={
            subjects.Maths.ToString(),
            subjects.CSharp.ToString(),
            subjects.Java.ToString(),
            subjects.Flutter.ToString(),
            subjects.Python.ToString(),
            subjects.WebDev.ToString()
        };

        Console.Write(subj[0]);
        for(int i = 1; i < subj.Length; i++)
        {
            Console.Write(", {0}",subj[i]);
        }

    }

    static void Main()
    {
        Student student = new Student();
        Console.WriteLine("This is a student registration portal");
        Console.Write("\nWhat is the name of the student (first name first) : ");
        student.fullName = Console.ReadLine();
        string[] name = student.fullName.Split(' ');

        Console.Write("\nWhat university does {0} attend : ", name[0]);
        student.university = Console.ReadLine();

        Console.Write("\nWhat course is {0} studying at {1} : ", name[0], student.university);
        student.course = Console.ReadLine();

        Console.Write("\nPlease enter {0}'s email : ", name[0]);
        student.email = Console.ReadLine();

        Console.Write("\nPlease enter {0}'s phone number : ", name[0]);
        student.phoneNum = Console.ReadLine();

        Console.WriteLine("\n\nThe relevant information concerning {0} are displayed below ", name[0]);
        student.showInfo(student);
    }

}