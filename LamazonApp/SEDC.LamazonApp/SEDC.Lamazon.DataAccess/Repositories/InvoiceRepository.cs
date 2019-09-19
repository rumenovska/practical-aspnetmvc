using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class InvoiceRepository: BaseRepository, IRepository<Invoice>
    {
        public InvoiceRepository(LamazonDbContext context) : base(context) { }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public Invoice GetById(int id)
        {
            return _context.Invoises.SingleOrDefault(i => i.Id == id);
                
        }

        public int Insert(Invoice entity)
        {
            _context.Invoises.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Invoice entity)
        {
            throw new NotImplementedException();
        }
    }
}
