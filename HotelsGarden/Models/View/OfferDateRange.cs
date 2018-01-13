using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class OfferDateRange
    {
        [ReadOnly(true)]
        public DateTime TravelStartDate { get; set; }

        [ReadOnly(true)]
        public DateTime TravelEndDate { get; set; }

        [ReadOnly(true)]
        public int LengthOfStay { get; set; }

        [ReadOnly(true)]
        public string TravelStartDateString {
            get {
                return TravelStartDate.ToString(Constants.DateTimeFormat);
            }
        }

        [ReadOnly(true)]
        public string TravelEndDateString
        {
            get
            {
                return TravelEndDate.ToString(Constants.DateTimeFormat);
            }
        }
    }
}
