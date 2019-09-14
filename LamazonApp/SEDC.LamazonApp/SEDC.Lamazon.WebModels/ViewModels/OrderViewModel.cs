using SEDC.Lamazon.WebModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public StatusTypeViewModel Status { get; set; }
        public double Price => Products.Sum(p => p.Ptice);
        public UserViewModel User { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        
    }
}
