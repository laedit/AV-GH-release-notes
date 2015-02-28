using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PushToAVEnv
{
    class Program
    {
        static void Main(string[] args)
        {
            var appVeyorApiUrl = Environment.GetEnvironmentVariable("APPVEYOR_API_URL");

            Console.WriteLine("AppVeyorApiUrl: {0}", appVeyorApiUrl);
            using (var webClient = new WebClient())
            {
                webClient.BaseAddress = appVeyorApiUrl;
                webClient.Headers["Accept"] = "application/json";
                webClient.Headers["Content-type"] = "application/json";
                webClient.UploadData("api/build/variables", "POST", Encoding.UTF8.GetBytes(data));
            }

            Console.WriteLine(data);
        }

        static string data = "{ \"name\": \"test_env_releasenotes\", \"value\": \"test\nmulti\nline\" }";
    }
}
