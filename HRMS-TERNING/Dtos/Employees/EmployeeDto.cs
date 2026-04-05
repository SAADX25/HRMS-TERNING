namespace HRMS_TERNING.Dtos.Employees
{
    public class EmployeeDto
    {
        public long? ID { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Position { get; set; }


        public DateTime? BirthDate { get; set; } // Optional / Nullable

        public long? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public string? DepartmentPhone { get; set; }

        public string? ManagerNamer { get; set; }

        public string? ManagerPhone { get; set; }
        public long? ManagerId { get; set; }
    }
}
