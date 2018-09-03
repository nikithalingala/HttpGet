using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Google google = new Google();
           string result= google.GooglePage();
            Console.WriteLine(result);
            Console.ReadKey();
        }
       
    }
}
