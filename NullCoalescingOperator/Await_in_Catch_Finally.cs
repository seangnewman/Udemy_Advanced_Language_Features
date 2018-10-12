using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedFeatures
{
    class Await_in_Catch_Finally
    {

        public static async void Demo()
        {
            try
            {
                WebRequest webRequest = WebRequest.Create("http://www.bitesizedcsharp.com");
                WebResponse response = await webRequest.GetResponseAsync();
            }catch(WebException exception)
            {
                await LogError(exception);
                Console.WriteLine("Exception asynchronously logged to file");
            }

        }

        private static async Task LogError(Exception exception)
        {
           using (StreamWriter writer = File.CreateText("error.log"))
            {
                await writer.WriteAsync(exception.Message);
            }
        }
    }
}
