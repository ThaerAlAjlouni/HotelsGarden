namespace HotelsGarden.Models.View
{
    public class HotelUrgencyInfo
    {
        public int AirAttachRemainingTime { get; set; }

        public int NumberOfPeopleViewing { get; set; }

        public int NumberOfPeopleBooked { get; set; }

        public int NumberOfRoomsLeft { get; set; }

        public object LastBookedTime { get; set; }

        public string AlmostSoldStatus { get; set; }

        public string Link { get; set; }

        public bool AirAttachEnabled { get; set; }
    }
}
