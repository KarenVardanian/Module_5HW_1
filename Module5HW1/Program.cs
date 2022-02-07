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
            await userService.FirstRequest();
            userService.TestMethod1Async();
        }
     }
}
