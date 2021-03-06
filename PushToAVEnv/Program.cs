﻿using System;
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

            using (var webClient = new WebClient())
            {
                webClient.BaseAddress = "appVeyorApiUrl";
                webClient.UploadData("api/build/variables", "POST", Encoding.UTF8.GetBytes(data));
            }
        }

        static string data = "{ \"name\": \"test_env_releasenotes\", \"value\": \"test\nmulti\nline\"}";
    }
}
