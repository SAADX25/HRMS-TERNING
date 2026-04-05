using System;

namespace HRMS_TERNING.Models
{
    public class Attendance
    {
        public long ID { get; set; }
        public long EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan ClockIn { get; set; }
        public TimeSpan? ClockOut { get; set; }

        public Employee Employee { get; set; }
    }
}
