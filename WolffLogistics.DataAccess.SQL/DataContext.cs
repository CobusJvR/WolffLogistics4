using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolffLogistics.Core.Models;

namespace WolffLogistics.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base ("DefaultConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
