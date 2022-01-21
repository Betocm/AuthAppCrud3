#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi2.Models;

namespace WebApi2.Data
{
    public class WebApi2Context : DbContext
    {
        public WebApi2Context (DbContextOptions<WebApi2Context> options)
            : base(options)
        {
        }

        public DbSet<WebApi2.Models.Employee> Employee { get; set; }
    }
}
