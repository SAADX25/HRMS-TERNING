namespace HRMS_TERNING.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string FlorNumber { get; set; }

        
        public List<string> Employee { get; set; } = new List<string>();




    }
}
