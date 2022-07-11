using System;

namespace BlazorApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Role Role { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string AuthData { get; set; }
    }
    public enum Role
    {
        Waiter, Menager, Owner
    }
}