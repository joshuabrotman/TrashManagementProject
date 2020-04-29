using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class Customer
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string pickupDay { get; set; }
        public DateTime suspendStart { get; set; }
        public DateTime suspendEnd { get; set; }
        public string street { get; set; }
        public int zipCode { get; set; }


        [ForeignKey("IdentityUser")] public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        

    }
}
