using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurHotels.Dto.Hotel
{
   public class SearchDto
    {
       
            public string City { get; set; }
            public string HotelName { get; set; }
            public DateTime from { get; set; }
            public DateTime to { get; set; }

            public List<RoomModel> Rooms { get; set; }
        }

        public class RoomModel
        {
            public string RoomNumber { get; set; }
            public int NumBeds { get; set; } 
        }
    }

