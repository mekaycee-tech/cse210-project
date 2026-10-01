public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Use the base class method GetStudentName() to access the private _studentName field
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}