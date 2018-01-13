namespace HotelsGarden.Models.View
{
    public class HotelPricingInfo
    {
        public double AveragePriceValue { get; set; }

        public double TotalPriceValue { get; set; }

        public double CrossOutPriceValue { get; set; }

        public double OriginalPricePerNight { get; set; }

        public string Currency { get; set; }

        public double PercentSavings { get; set; }

        public bool Drr { get; set; }
    }
}
