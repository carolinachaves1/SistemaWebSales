using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
