using System;

namespace HotelsGarden.Models.View
{
    public class HotelInfo
    {
        public string HotelId { get; set; }

        public string HotelName { get; set; }

        public string LocalizedHotelName { get; set; }

        public string HotelDestination { get; set; }

        public string HotelDestinationRegionID { get; set; }

        public string HotelLongDestination { get; set; }

        public string HotelStreetAddress { get; set; }

        public string HotelCity { get; set; }

        public string HotelProvince { get; set; }

        public string HotelCountryCode { get; set; }

        public double HotelLatitude { get; set; }

        public double HotelLongitude { get; set; }

        public string HotelStarRating { get; set; }

        public double HotelGuestReviewRating { get; set; }

        public int HotelReviewTotal { get; set; }

        public Uri HotelImage { get; set; }

        public bool VipAccess { get; set; }

        public bool IsOfficialRating { get; set; }
    }
}
