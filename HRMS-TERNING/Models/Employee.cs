namespace HRMS_TERNING.Models
{
    public class Employee
    {

        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }


        public DateTime BirthDate { get; set; } // Optional / Nullable

        public long? DepartmentId { get; set; }
        public long? ManagerId { get; set; }

        // New properties based on ER Diagram
        public long? UserId { get; set; }
        public string Phone { get; set; }
        public DateTime? HireDate { get; set; }
        public long? PositionId { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Department Department { get; set; }
        public Position PositionRef { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
        public ICollection<Salary> Salaries { get; set; }
    }

    }