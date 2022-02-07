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

    public class UserService
    {
        
         public async Task FirstRequest()
        {

            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<User>(content);
                    Console.WriteLine(user.FirstName);
                }
            }
        }
        public async Task ThirdRequest()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/23");

                if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
