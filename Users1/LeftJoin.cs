namespace Users1;

public class LeftJoin
{
    public sealed record Student
    {
        public required Guid Id { get; init; }
        public required string FullName { get; init; }
    }

    public sealed record Course
    {
        public required Guid Id { get; init; }
        public required string Title { get; init; }
        public required Guid StudentId { get; init; } 
    }

    public List<(Student Student, List<Course> Courses)> GetStudentsWithCourses(
        ICollection<Student> students,
        ICollection<Course> courses)
    {
        return students.GroupJoin(courses, 
            x => x.Id, 
            g => g.StudentId, 
            (x,g) => (x,g.ToList())).ToList();
            
    }
    
}
