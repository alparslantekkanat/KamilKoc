using CloudTours.Domain;
using CloudTours.Management.Presentation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudTours.Management.Application.Trips
{
    public interface ITripService
    {
        ICollection<Trip> GetTrips();
       
        //Trip GetTripById(int id);
       

    }
}
