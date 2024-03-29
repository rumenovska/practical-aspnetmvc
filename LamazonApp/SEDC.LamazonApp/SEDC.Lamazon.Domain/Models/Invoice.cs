﻿using SEDC.Lamazon.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEDC.Lamazon.Domain.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public PaymentType Payment { get; set; }

        [Required]
        public string Address { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
