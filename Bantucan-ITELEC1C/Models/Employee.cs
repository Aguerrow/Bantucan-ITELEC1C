namespace Bantucan_ITELEC1C.Models
{

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsTenured { get; set; }
        public decimal SalaryPerHour { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string DomainName { get; set; }
        public string UserName { get; set; }

    }
}
