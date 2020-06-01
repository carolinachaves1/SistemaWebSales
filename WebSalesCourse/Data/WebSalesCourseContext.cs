using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSalesCourse.Models;

namespace WebSalesCourse.Data
{
    public class WebSalesCourseContext : DbContext
    {
        public WebSalesCourseContext (DbContextOptions<WebSalesCourseContext> options)
            : base(options)
        {
        }

        public DbSet<WebSalesCourse.Models.Department> Department { get; set; }
    }
}
