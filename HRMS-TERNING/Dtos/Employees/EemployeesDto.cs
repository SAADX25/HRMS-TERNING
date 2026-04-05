namespace HRMS_TERNING.Dtos.Employees
{
    public class EemployeesDto
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }


        public DateTime BirthDate { get; set; } // Optional / Nullable

        public long? DepartmentId { get; set; }

        public long? DepartmentName { get; set; }
        public long? ManagerId { get; set; }
    }

    }

