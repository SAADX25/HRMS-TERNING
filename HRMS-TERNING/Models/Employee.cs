namespace HRMS_TERNING.Models
{
    public class Employee
    {

        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public DateTime BirthDate { get; set; }  //optional / Nullable

    }

}