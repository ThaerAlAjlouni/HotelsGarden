namespace HotelsGarden.Models.View
{
    public class Hotel
    {
        public OfferDateRange OfferDateRange { get; set; }

        public Destination Destination { get; set; }

        public HotelInfo HotelInfo { get; set; }

        public HotelUrgencyInfo HotelUrgencyInfo { get; set; }

        public HotelPricingInfo HotelPricingInfo { get; set; }

        public HotelUrls HotelUrls { get; set; }
    }

}
