using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class Hotel
    {
        [ReadOnly(true)]
        public OfferDateRange OfferDateRange { get; set; }

        [ReadOnly(true)]
        public Destination Destination { get; set; }

        [ReadOnly(true)]
        public HotelInfo HotelInfo { get; set; }

        [ReadOnly(true)]
        public HotelUrgencyInfo HotelUrgencyInfo { get; set; }

        [ReadOnly(true)]
        public HotelPricingInfo HotelPricingInfo { get; set; }

        [ReadOnly(true)]
        public HotelUrls HotelUrls { get; set; }
    }
}
