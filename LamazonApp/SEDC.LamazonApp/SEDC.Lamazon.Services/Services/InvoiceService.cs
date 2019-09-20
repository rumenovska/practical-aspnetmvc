using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepo;
        private readonly IRepository<Order> _orderRepo;
        private readonly IMapper _mapper;

        public InvoiceService(IRepository<Invoice> invoiceRepo, IRepository<Order> orderRepo, IMapper mapper)
        {
            _invoiceRepo = invoiceRepo;
            _orderRepo = orderRepo;
            _mapper = mapper;
        }
        public InvoiceViewModel GetOrderById(int id)
        {
            return _mapper.Map<InvoiceViewModel>(_invoiceRepo.GetById(id);
        }

        public int CreateOrder(InvoiceViewModel invoice, int orderId)
        {
            Order order = _orderRepo.GetById(orderId);

            Invoice mappedInvoice = _mapper.Map<Invoice>(invoice);

            mappedInvoice.Order = order;

            return _invoiceRepo.Insert(mappedInvoice);
        }

       
    }
}
