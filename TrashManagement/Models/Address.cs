using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class Address
    {
        [Key] public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

        [ForeignKey("Customer")] public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
