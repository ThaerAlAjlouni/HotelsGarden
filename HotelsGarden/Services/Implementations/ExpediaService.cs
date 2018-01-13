using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HotelsGarden.Models.Domain;
using HotelsGarden.Models.View;
using Newtonsoft.Json;
using ExpdiaOffers = HotelsGarden.Models.Domain.Expedia.Offers;

namespace HotelsGarden.Services
{
    public class ExpediaService : IExpediaService
    {
        public ExpediaService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private readonly IMapper mapper;

        public async Task<Offers> GetOffersAsync(SearchFilters filters)
        {
            var client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");

            client.BaseAddress = new Uri("https://offersvc.expedia.com");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            var resourceUrl = String.Concat("/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel", GetQueryString(filters));
            var response = await client.GetAsync(resourceUrl);
            var stringData = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<ExpediaOffers>(stringData);

            return mapper.Map<Offers>(data.Offers);
        }

        private string GetQueryString(SearchFilters filters)
        {
            if (filters == null) {
                return String.Empty;
            }

            var queryBuilder = new StringBuilder();

            if (!String.IsNullOrWhiteSpace(filters.DestinationName))
            {
                queryBuilder.AppendFormat("&destinationName={0}", Uri.EscapeDataString(filters.DestinationName));
            }

            if (filters.MinTripStartDate.HasValue)
            {
                queryBuilder.AppendFormat("&minTripStartDate=:{0}", filters.MinTripStartDate.Value.ToString(Constants.ApiDateTimeFormat));
            }

            if (filters.MaxTripStartDate.HasValue)
            {
                queryBuilder.AppendFormat("&maxTripStartDate=:{0}", filters.MaxTripStartDate.Value.ToString(Constants.ApiDateTimeFormat));
            }

            if (filters.LengthOfStay > 0)
            {
                queryBuilder.AppendFormat("&lengthOfStay={0}", filters.LengthOfStay);
            }

            if (filters.MinGuestRating > 0)
            {
                queryBuilder.AppendFormat("&minGuestRating={0}", filters.MinGuestRating);
            }

            if (filters.MaxGuestRating > 0)
            {
                queryBuilder.AppendFormat("&maxGuestRating={0}", filters.MaxGuestRating);
            }

            if (filters.MinStarRating > 0)
            {
                queryBuilder.AppendFormat("&minStarRating={0}", filters.MinStarRating);
            }

            if (filters.MaxStarRating > 0)
            {
                queryBuilder.AppendFormat("&maxStarRating={0}", filters.MaxStarRating);
            }

            if (filters.MinTotalRate > 0)
            {
                queryBuilder.AppendFormat("&minTotalRate={0}", filters.MinTotalRate);
            }

            if (filters.MaxTotalRate > 0)
            {
                queryBuilder.AppendFormat("&maxTotalRate={0}", filters.MaxTotalRate);
            }

            return queryBuilder.ToString();
        }
    }
}
