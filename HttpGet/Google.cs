using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpGet
{
    class Google
    {
        public String GooglePage()
        {
            string url = "http://www.google.com";
            HttpClient httpClient = new HttpClient();
            Task<string> getTask = httpClient.GetStringAsync(url);
            string getUrlResult = getTask.Result;
         

            return getUrlResult;
        }
    }
}
