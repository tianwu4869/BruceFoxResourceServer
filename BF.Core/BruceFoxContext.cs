using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BF.Core
{
    public class BruceFoxContext : DbContext
    {
        public BruceFoxContext() : base("MyConnection")
        {

        }

        public DbSet<Tasks> TasksSet { get; set; }
    }
}
