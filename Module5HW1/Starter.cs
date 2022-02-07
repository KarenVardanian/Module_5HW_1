using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HW1
{
    public class Starter
    {
        private readonly HttpClient _httpClient;
        public Starter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
