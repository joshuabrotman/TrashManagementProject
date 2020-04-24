using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashManagement.Models
{
    public class Suspend
    {
        [Key] public int Id { get; set; }
        public DateTime SuspendStart { get; set; }
        public DateTime SuspendEnd { get; set; }

        [ForeignKey("Customer")] public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
