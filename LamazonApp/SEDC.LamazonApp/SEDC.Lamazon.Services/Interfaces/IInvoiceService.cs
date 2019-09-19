using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IInvoiceService
    {
        InvoiceViewModel GetOrderById(int id);
        int CreateOrder(InvoiceViewModel invoice, int orderId);
    }
}
