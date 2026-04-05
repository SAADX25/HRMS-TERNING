namespace HRMS_TERNING.Models
{
    public class Department
    {

        public long Id { get; set; }

        public string Name { get; set; }


        public string Description { get; set; } 

        public string? FloorNumber { get; set; }

        public string Location { get; set; }

        public ICollection<Position> Positions { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
