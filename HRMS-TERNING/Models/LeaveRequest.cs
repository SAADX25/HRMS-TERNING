using System;

namespace HRMS_TERNING.Models
{
    public class LeaveRequest
    {
        public long ID { get; set; }
        public long EmployeeId { get; set; }
        public long? ApprovedById { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string RejectionReason { get; set; }

        public Employee Employee { get; set; }
        public User ApprovedBy { get; set; }
    }
}
