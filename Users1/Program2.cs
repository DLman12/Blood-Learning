namespace Users1;

public class Program2
{
    public static void Main(string[] args)
    {

        var students = new List<LeftJoin.Student>
        {
            new() { Id = Guid.NewGuid(), FullName = "Иван Иванов" },
            new() { Id = Guid.NewGuid(), FullName = "Мария Петрова" }
        };

        var courses = new List<LeftJoin.Course>
        {
            new() { Id = Guid.NewGuid(), Title = "Математика", StudentId = students[0].Id },
            new() { Id = Guid.NewGuid(), Title = "Физика", StudentId = students[0].Id },
            new() { Id = Guid.NewGuid(), Title = "История", StudentId = students[1].Id }
        };

        var result = new LeftJoin().GetStudentsWithCourses(students, courses);
        Console.WriteLine(result);
    }
}