using Module5HW1.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1.Services
{
    public class ResourceService
    {
        public async Task FourthRequest()
        {

            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown");
               // Console.WriteLine(result);
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    string s = content;
                    Console.WriteLine(s);
                    var user = JsonConvert.DeserializeObject<Root>(s);
                    Console.WriteLine();
                    Console.WriteLine(user.per_page);
                   
                }
            }
        }
        
        public async Task FifthRequest()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/2");
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<RootUserSecond>(content);
                    Console.WriteLine();
                    Console.WriteLine(user.data.year);

                }
            }
        }

        public async Task SeventhRequest()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/23");

                if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("Not found");
                }
            }
        }

    }
}
