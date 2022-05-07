using CloudTours.Domain;
using CloudTours.Management.Application.Trips;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudTours.Management.Presentation.Services
{
    public class FakeTripService : ITripService
    {

        private List<Trip> trips;
        public FakeTripService()
        {

            trips = new List<Trip>
            {
             new Trip{Id = 1, Name ="Antalya-Zonguldak" , Description ="04.05.2022 Saat 18:00" , Price =400 , ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg" },
             new Trip{Id = 2, Name ="Antalya-İstanbul" , Description="05.05.2022 Saat 18:00",Price=500, ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg"},
             new Trip{Id = 3, Name ="İstanbul-Ankara", Description="06.05.2022 Saat 18:00", Price= 300, ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg"},
             new Trip{Id = 4, Name ="Antalya-Zonguldak" , Description ="04.05.2022 Saat 18:00" , Price =400 , ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg" },
             new Trip{Id = 5, Name ="Antalya-İstanbul" , Description="05.05.2022 Saat 18:00",Price=500, ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg"},
             new Trip{Id = 6, Name ="İstanbul-Ankara", Description="06.05.2022 Saat 18:00", Price= 300, ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg"},
             new Trip{Id = 7, Name ="Antalya-Zonguldak" , Description ="04.05.2022 Saat 18:00" , Price =400 , ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg" },
             new Trip{Id = 8, Name ="Antalya-İstanbul" , Description="05.05.2022 Saat 18:00",Price=500, ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg"},
             new Trip{Id = 9, Name ="İstanbul-Ankara", Description="06.05.2022 Saat 18:00", Price= 300, ImageUrl="https://www.lojiyol.com/wp-content/uploads/2020/12/2018_MAN_LionsCoach_E6c_September.jpg"}
            };
            
        }

        public static Task GetTripById(int id)
        {
            throw new NotImplementedException();
        }

        public static Task<bool> IsExist(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Trip> GetTrips()
        {
            return trips;
        }

      
    }
}
