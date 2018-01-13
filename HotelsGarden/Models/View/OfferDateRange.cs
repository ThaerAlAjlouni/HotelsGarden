using System;

namespace HotelsGarden.Models.View
{
    public class OfferDateRange
    {
        public DateTime TravelStartDate { get; set; }

        public DateTime TravelEndDate { get; set; }

        public int LengthOfStay { get; set; }

        public string TravelStartDateString {
            get {
                return TravelStartDate.ToString(Constants.DateTimeFormat);
            }
        }

        public string TravelEndDateString
        {
            get
            {
                return TravelEndDate.ToString(Constants.DateTimeFormat);
            }
        }
    }
}
