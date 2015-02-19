using System.Collections.Generic;
using Vehicles.Model;

namespace Vehicles.Web.Models.ViewModels
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            Vehicles = new List<Vehicle>();
        }

        public int Id { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}