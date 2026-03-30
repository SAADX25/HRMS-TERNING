namespace HRMS_TERNING.Dtos.Employees
{
    public class SaveEmployeeDto
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Position { get; set; }
    }
}
