using System;

namespace CommonLayer
{
    public class EmployeeModel
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}
