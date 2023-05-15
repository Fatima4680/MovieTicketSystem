using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   internal class Context : DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ManagerToken> ManagerTokens { get; set; }
        public DbSet<SeatDetail> SeatDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
