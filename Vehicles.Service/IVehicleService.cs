using System.Collections.Generic;
using System.ServiceModel;
using Vehicles.Model;

namespace Vehicles.Service
{
    [ServiceContract]
    public interface IVehicleService
    {
        [OperationContract]
        Vehicle GetVehicle(int vehicleId);

        [OperationContract]
        void AddVehicle(Vehicle vehicle);
        [OperationContract]
        List<Vehicle> GetAllVehicles();
    }
}
