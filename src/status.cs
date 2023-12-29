using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading; 

namespace status
{
    class stat
    {
        static void SleepFunc(int mlsec)
        {
            Thread.Sleep(mlsec);
        }

        public static async Task status(string[] args)
        {
            Console.WriteLine("if you are reading this: initialization success!");

            int bgTime = 1000;
            SleepFunc(bgTime);

            string ping = "http://tlochsta.dev";

            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(1); 

                try
                {
                    HttpResponseMessage response = await client.GetAsync(ping); 

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Online - HTTP-Available [200 OK]");
                    }
                    else
                    {
                        Console.WriteLine($"Response status: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine(" ERROR!: HTTP Site Status Offline, modify the 'ping' string and input a valid domain.");
                }
            }
        }
    }
}

