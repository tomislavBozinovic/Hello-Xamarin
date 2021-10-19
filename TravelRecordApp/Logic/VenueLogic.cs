﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TravelRecordApp.Model;

namespace TravelRecordApp.Logic
{
    public class VenueLogic
    {
        public static async Task<List<Venue>> GetVenues(double lat, double lon)
        {
            List<Venue> venues = new List<Venue>();

            string url = VenueRoot.GenerateUrl(lat, lon);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var venueRoot = JsonConvert.DeserializeObject<VenueRoot>(json);

                venues = venueRoot.response.venues as List<Venue>;
            }

            return venues;
        }
    }
}