using System.Data.Common;

namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the operation number you want to perform");
            int val = Convert.ToInt32(Console.ReadLine());
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Sachin", "145165", "Nammkum", 16));
            students.Add(new Student(2, "Sachin", "145165", "Nammkum", 16));
            students.Add(new Student(3, "Sachin", "145165", "Nammkum", 16));
            students.Add(new Student(4, "Kapil", "52513231", "Ranchi", 21));
            students.Add(new Student(5, "Wakil", "52513231", "Ranchi", 21));
            students.Add(new Student(6, "Tom", "52513231", "Ranchi", 14));
            students.Add(new Student(7, "Charlie", "52513231", "Delhi", 12));
            students.Add(new Student(8, "Chandan", "52513231", "Bangalore", 5));
            switch (val)
            {
                case 1:
                    foreach(Student student in students) 
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 2:
                    List<Student> AgeLimitList = students.Where(a => a.Age >= 12 && a.Age <= 16).ToList();
                    //Console.WriteLine(ageLimitList.Count);
                    foreach (Student student in AgeLimitList)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 3:
                    List<Student> DesendingList = (from stud in students orderby stud.Age select stud).ToList();
                    foreach (Student student in DesendingList)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 4:
                    var GroupBy = (from stud in students group stud by stud.Address into newgroup select newgroup);
                    foreach(var addresslist in GroupBy)
                    {
                        Console.WriteLine("Location : " + addresslist.Key);
                        foreach(Student studen in addresslist)
                        {
                            Console.WriteLine(studen);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    var OnlyThreeList = (from stud in students select stud).Take(3).ToList();
                    foreach(Student student in OnlyThreeList)
                    {
                        Console.WriteLine(student);
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    Console.WriteLine("Name the person you are looking for : ");
                    String find = Console.ReadLine();
                    var studList = students.FindAll(a => a.Name == find);
                    foreach(var stud in studList)
                    {
                        Console.WriteLine(stud);
                        Console.WriteLine();
                    }
                    if (studList.Count == 0) Console.WriteLine("No match found");
                    break;

            }
        }
    }
}
