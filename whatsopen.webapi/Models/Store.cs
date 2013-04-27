using System;
using System.Collections.Generic;
namespace whatsopen.webapi.Models
{
  
    
    public partial class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PostCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime MondayOpenTime { get; set; }
        public DateTime MondayCloseTime { get; set; }
        public DateTime TuesdayOpenTime { get; set; }
        public DateTime TuesdayCloseTime { get; set; }
        public DateTime WednesdayOpenTime { get; set; }
        public DateTime WednesdayCloseTime { get; set; }
        public DateTime ThursdayOpenTime { get; set; }
        public DateTime ThursdayCloseTime { get; set; }
        public DateTime FridayOpenTime { get; set; }
        public DateTime FridayCloseTime { get; set; }
        public DateTime SaturdayOpenTime { get; set; }
        public DateTime SaturdayCloseTime { get; set; }
        public DateTime SundayOpenTime { get; set; }
        public DateTime SundayCloseTime { get; set; }
        public string Notes { get; set; }
        public decimal? Distance { get; set; }

        public string VenueType { get; set; }
        public string PictureUrl { get; set; }
        public double Rating { get; set; }
        public string VenueUrl { get; set; }
        public string Neighborhoods { get; set; }

        public int ImportStatus { get; set; }
        

    }
}
