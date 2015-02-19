using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Model.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext()
            : base("VehicleContext")
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Person> Owners { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
