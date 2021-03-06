﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vehicles.Web.VehicleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VehicleService.IVehicleService")]
    public interface IVehicleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehicleService/GetVehicle", ReplyAction="http://tempuri.org/IVehicleService/GetVehicleResponse")]
        Vehicles.Model.Vehicle GetVehicle(int vehicleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehicleService/AddVehicle", ReplyAction="http://tempuri.org/IVehicleService/AddVehicleResponse")]
        void AddVehicle(Vehicles.Model.Vehicle vehicle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVehicleService/GetAllVehicles", ReplyAction="http://tempuri.org/IVehicleService/GetAllVehiclesResponse")]
        System.Collections.Generic.List<Vehicles.Model.Vehicle> GetAllVehicles();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVehicleServiceChannel : Vehicles.Web.VehicleService.IVehicleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VehicleServiceClient : System.ServiceModel.ClientBase<Vehicles.Web.VehicleService.IVehicleService>, Vehicles.Web.VehicleService.IVehicleService {
        
        public VehicleServiceClient() {
        }
        
        public VehicleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VehicleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehicleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehicleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Vehicles.Model.Vehicle GetVehicle(int vehicleId) {
            return base.Channel.GetVehicle(vehicleId);
        }
        
        public void AddVehicle(Vehicles.Model.Vehicle vehicle) {
            base.Channel.AddVehicle(vehicle);
        }
        
        public System.Collections.Generic.List<Vehicles.Model.Vehicle> GetAllVehicles() {
            return base.Channel.GetAllVehicles();
        }
    }
}
