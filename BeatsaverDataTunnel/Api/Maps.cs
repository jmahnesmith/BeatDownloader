using BeatsaverDataTunnel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeatsaverDataTunnel.Api
{
    public class Maps
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
