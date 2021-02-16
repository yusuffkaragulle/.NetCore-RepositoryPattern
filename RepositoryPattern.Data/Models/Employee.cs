using System;

namespace RepositoryPattern.Data.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Department { get; set; }
    }
}
