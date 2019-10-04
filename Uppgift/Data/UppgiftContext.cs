using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Uppgift.Models
{
    public class UppgiftContext : DbContext
    {
        public UppgiftContext (DbContextOptions<UppgiftContext> options)
            : base(options)
        {
        }

        public DbSet<Uppgift.Models.Article> Article { get; set; }
    }
}
