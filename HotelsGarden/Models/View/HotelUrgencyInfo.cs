﻿using System.ComponentModel;

namespace HotelsGarden.Models.View
{
    public class HotelUrgencyInfo
    {
        [ReadOnly(true)]
        public int AirAttachRemainingTime { get; set; }

        [ReadOnly(true)]
        public int NumberOfPeopleViewing { get; set; }

        [ReadOnly(true)]
        public int NumberOfPeopleBooked { get; set; }

        [ReadOnly(true)]
        public int NumberOfRoomsLeft { get; set; }

        [ReadOnly(true)]
        public object LastBookedTime { get; set; }

        [ReadOnly(true)]
        public string AlmostSoldStatus { get; set; }

        [ReadOnly(true)]
        public string Link { get; set; }

        [ReadOnly(true)]
        public bool AirAttachEnabled { get; set; }
    }
}
