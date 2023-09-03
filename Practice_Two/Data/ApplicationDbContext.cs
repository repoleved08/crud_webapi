using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice_Two.Entities;

namespace Practice_Two.Data
{
    public class ApplicationDbContext : DbContext
    {
       public DbSet<EmsUsers> emsUsers{ get; set; }
       public DbSet<EmsEvent> emsEvents{ get; set; }

       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}
