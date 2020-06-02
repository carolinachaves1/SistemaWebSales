using System.Collections.Generic;
using System.Linq;
using WebSalesCourse.Data;
using WebSalesCourse.Models;

namespace WebSalesCourse.Services
{
    public class DepartmentService
    {
        private readonly WebSalesCourseContext _context;

        public DepartmentService(WebSalesCourseContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
