namespace HRMS_TERNING.Dtos.Employees
{
    public class EemployeesDto
    {
        public long ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string? Email { get; set; }

        public string? Position { get; set; }

        public DateTime? BirthDate { get; set; }  //optional / Nullable
    }
}
