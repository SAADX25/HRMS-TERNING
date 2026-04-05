using System;
using System.Collections.Generic;

namespace HRMS_TERNING.Models
{
    public class User
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime? LastLogin { get; set; }

        // Navigation properties
        public Employee Employee { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<LeaveRequest> ApprovedLeaveRequests { get; set; }
    }
}
