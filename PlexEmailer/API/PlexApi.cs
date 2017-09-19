using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using PlexEmailer.Models;
using PlexEmailer.Models.PlexXml;
using PlexEmailer.Utils;
using Formatting = Newtonsoft.Json.Formatting;

namespace PlexEmailer.API
{
    public class PlexApi
    {
        public string baseUrl { get; set; }
        public string token { get; set; }

        public async Task<MediaContainer> BaseServerCapabilities()
        {
            var url = "?X-Plex-Token=" + token;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string xml = await response.Content.ReadAsStringAsync();

                    return XmlHelper<MediaContainer>.Deserialize(xml);
                }
                else
                {
                    return null;
                }
            }
        }
        
        
        public async Task<MediaContainer> ListSectionContents(string sectinId)
        {
            var url = "library/sections/" + sectinId + "/all?X-Plex-Token=" + token;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string xml = await response.Content.ReadAsStringAsync();
                    
                    return XmlHelper<MediaContainer>.Deserialize(xml);
                }
                else
                {
                    return null;
                }
            }
        }
        
        public async Task<MediaContainer> ListDefinedLibraries()
        {
            var url = "library/sections?X-Plex-Token=" + token;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string xml = await response.Content.ReadAsStringAsync();
                    
                    return XmlHelper<MediaContainer>.Deserialize(xml);
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<MediaContainer> ListItemDetail(int key)
        {
            var url = "library/metadata/" + key + "?X-Plex-Token=" + token;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string xml = await response.Content.ReadAsStringAsync();
                    
                    return XmlHelper<MediaContainer>.Deserialize(xml);
                }
                else
                {
                    return null;
                }
            }
        }
        
        
        public async Task<MediaContainer> ByKey(string key)
        {
            var url = key + "?X-Plex-Token=" + token;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string xml = await response.Content.ReadAsStringAsync();
                    
                    return XmlHelper<MediaContainer>.Deserialize(xml);
                }
                else
                {
                    return null;
                }
            }
        }

    }
}