using System;
using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class HotelUrls
    {
        [ReadOnly(true)]
        public Uri HotelInfosite { get; set; }

        [ReadOnly(true)]
        public Uri HotelSearchResult { get; set; }
    }
}
