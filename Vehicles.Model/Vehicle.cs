using System.Runtime.Serialization;

namespace Vehicles.Model
{
    [DataContract]
    public class Vehicle
    {
        public Vehicle()
        {
            Owner = new Person();
        }

        [DataMember]
        public int VehicleId { get; set; }
        [DataMember]
        public string Vin { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public string Make { get; set; }
        [DataMember]
        public string ModelType { get; set; }
        [DataMember]
        public Person Owner { get; set; }
    }
}