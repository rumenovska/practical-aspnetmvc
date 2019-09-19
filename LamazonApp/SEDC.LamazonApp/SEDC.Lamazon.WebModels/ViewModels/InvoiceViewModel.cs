using SEDC.Lamazon.WebModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }

        public PaymentTypeViewModel Payment { get; set; }

        public string Address { get; set; }

        public OrderViewModel Order { get; set; }
    }
}
