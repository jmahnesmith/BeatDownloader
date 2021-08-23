using BeatDownloaderLib.API.Models;
using BeatsaverDataTunnel.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeatDownloaderLib.API.DataAccess
{
    public class MapEndpoint
    { 
        public async Task<MapDetail> GetMapById(string id)
        {
            using (HttpResponseMessage response = await APIHelper.client.GetAsync($"https://api.beatsaver.com/maps/id/{id}"))
            {
                response.EnsureSuccessStatusCode();

                var resultString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MapDetail>(resultString);

            }
        }
    }
}
