namespace HRMS_TERNING.Controllers
{
    internal class EmployeeDto
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int? Age { get; set; }
        public long ID { get; internal set; }
        public string Email { get; internal set; }
    }
}