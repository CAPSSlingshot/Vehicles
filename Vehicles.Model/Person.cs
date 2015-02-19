using System.Runtime.Serialization;

namespace Vehicles.Model
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
