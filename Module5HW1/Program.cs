using Module5HW1.DTO;
using Module5HW1.Services;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Module5HW1
{
    public class Program
    {  
        public static async Task Main(string[] args)
        {
            var userService = new UserService();
            var resource = new ResourceService();
            // await userService.FirstRequest();
            // await userService.ThirdRequest();
            //  await resource.FourthRequest();

            await resource.SeventhRequest();
        }
     }
}
