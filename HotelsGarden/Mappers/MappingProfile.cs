﻿using System;
using AutoMapper;
using HotelsGarden.Models.View;

namespace HotelsGarden.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Domain.Expedia.Destination, Destination>();
            CreateMap<Models.Domain.Expedia.Hotel, Hotel>();
            CreateMap<Models.Domain.Expedia.HotelPricingInfo, HotelPricingInfo>();
            CreateMap<Models.Domain.Expedia.HotelUrgencyInfo, HotelUrgencyInfo>();
            CreateMap<Models.Domain.Expedia.OfferInfo, OfferInfo>();
            CreateMap<Models.Domain.Expedia.Offers, Offers>();
            CreateMap<Models.Domain.Expedia.Persona, Persona>();
            CreateMap<Models.Domain.Expedia.UserInfo, UserInfo>();

            CreateMap<Models.Domain.Expedia.HotelInfo, HotelInfo>()
                .ForMember(
                    dest => dest.HotelImage,
                    opts => opts.MapFrom(src => new Uri(Uri.UnescapeDataString(src.HotelImageUrl))));

            CreateMap<Models.Domain.Expedia.HotelUrls, HotelUrls>()
                .ForMember(
                    dest => dest.HotelInfosite,
                    opts => opts.MapFrom(src => new Uri(Uri.UnescapeDataString(src.HotelInfositeUrl)))
                ).ForMember(
                    dest => dest.HotelSearchResult,
                    opts => opts.MapFrom(src => new Uri(Uri.UnescapeDataString(src.HotelSearchResultUrl)))
                );

            CreateMap<Models.Domain.Expedia.OfferDateRange, OfferDateRange>()
                .ForMember(
                    dest => dest.TravelEndDate,
                    opts => opts.MapFrom(src => new DateTime(src.TravelEndDate[0], src.TravelEndDate[1], src.TravelEndDate[2]))
                ).ForMember(
                    dest => dest.TravelStartDate,
                    opts => opts.MapFrom(src => new DateTime(src.TravelStartDate[0], src.TravelStartDate[1], src.TravelStartDate[2]))
                );
        }
    }
}