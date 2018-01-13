using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class HotelInfo
    {
        [ReadOnly(true)]
        public string HotelId { get; set; }

        [ReadOnly(true)]
        public string HotelName { get; set; }

        [ReadOnly(true)]
        public string LocalizedHotelName { get; set; }

        [ReadOnly(true)]
        public string HotelDestination { get; set; }

        [ReadOnly(true)]
        public string HotelDestinationRegionID { get; set; }

        [ReadOnly(true)]
        public string HotelLongDestination { get; set; }

        [ReadOnly(true)]
        public string HotelStreetAddress { get; set; }

        [ReadOnly(true)]
        public string HotelCity { get; set; }

        [ReadOnly(true)]
        public string HotelProvince { get; set; }

        [ReadOnly(true)]
        public string HotelCountryCode { get; set; }

        [ReadOnly(true)]
        public double HotelLatitude { get; set; }

        [ReadOnly(true)]
        public double HotelLongitude { get; set; }

        [ReadOnly(true)]
        public string HotelStarRating { get; set; }

        [ReadOnly(true)]
        public double HotelGuestReviewRating { get; set; }

        [ReadOnly(true)]
        public int HotelReviewTotal { get; set; }

        [ReadOnly(true)]
        public Uri HotelImage { get; set; }

        [ReadOnly(true)]
        public bool VipAccess { get; set; }

        [ReadOnly(true)]
        public bool IsOfficialRating { get; set; }
    }
}
