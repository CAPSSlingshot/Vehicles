using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vehicles.Model;
using Vehicles.Model.DAL;

namespace Vehicles.Service
{
    public class VehicleService : IVehicleService
    {
        public Vehicle GetVehicle(int vehicleId)
        {
            using (var context = new VehicleContext())
            {
                return context.Vehicles.Include(p => p.Owner).FirstOrDefault(v => v.VehicleId == vehicleId);
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            using (var context = new VehicleContext())
            {
                context.Vehicles.Add(vehicle);
                context.SaveChanges();
            }
        }

        public List<Vehicle> GetAllVehicles()
        {
            using (var context = new VehicleContext())
            {
                return context.Vehicles.Include(p => p.Owner).ToList();
            }
        }
    }   
}
