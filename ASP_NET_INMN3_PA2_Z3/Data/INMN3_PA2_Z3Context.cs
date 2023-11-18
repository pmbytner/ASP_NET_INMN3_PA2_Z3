using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN3_PA2_Z3.Models;

namespace ASP_NET_INMN3_PA2_Z3.Data
{
    public class INMN3_PA2_Z3Context : DbContext
    {
        public INMN3_PA2_Z3Context (DbContextOptions<INMN3_PA2_Z3Context> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
