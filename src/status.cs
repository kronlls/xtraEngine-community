using System;
using System.Net.Http;
using System.Threading.Tasks;
/* 
[-] Init function script
[-] Written 12/29/23
[-] WARNING: DO NOT REWRITE THIS UNLESS YOU HAVE KNOWLEDGE ON THE PROGRAM. 
*/

class stat{
  
   static void SleepFunc(int mlsec){

    Thread.Sleep(mlsec);
  

   }




  
  public static void status(){
  
  Console.WriteLine("if you are reading this: initialization success!");
    //[-] Writes message confirming the initialization
   
    int bgTime = 1000;

    SleepFunc(bgTime);

    string ping = "http://tlochsta.dev";


     using (HttpClient client = new HttpClient())
        {
            client.Timeout = TimeSpan.FromSeconds(1); // Set the timeout to 1 second

            try
            {
                HttpResponseMessage response = await client.GetAsync(urlToPing);
                
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
                Console.WriteLine("Offline or timeout");
            }
        }
    }
}

