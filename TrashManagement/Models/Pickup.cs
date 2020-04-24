using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class Pickup
    {
        [Key] public int Id { get; set; }
        public DateTime TimeScheduled { get; set; }
        public DateTime TimeCompleted { get; set; }

        [ForeignKey("Customer")] public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Employee")] public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
