using HotelListing.API.Models.Country;

namespace HotelListing.API.Data
{
    public class Country : BaseCountryDto
    {
        public int Id { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}