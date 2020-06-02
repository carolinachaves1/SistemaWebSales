using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesCourse.Data;
using WebSalesCourse.Models;

namespace WebSalesCourse.Services
{
    public class SellerService
    {
        private readonly WebSalesCourseContext _context;

        public SellerService(WebSalesCourseContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

    }
}
