using System.Collections.Generic;

namespace HRMS_TERNING.Models
{
    public class Position
    {
        public long ID { get; set; }
        public long DepartmentId { get; set; }
        public string Title { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }

        public Department Department { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
