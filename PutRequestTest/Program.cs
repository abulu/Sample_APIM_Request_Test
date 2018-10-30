using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PutRequestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello Test API Put request !");

            //string postUrl = @"https://ptit.azure-api.cn/crm/v1/1/labels";
            //string postUrl = @"https://ptit-cars.azure-api.cn/crm/v1/1/labels";
            string postUrl = @"https://api-service-demo-01.azure-api.cn/apim/api/values";
        
            var request = (HttpWebRequest)WebRequest.Create(postUrl);
            //request.Method = "PUT";
            request.Method = "GET";
            request.ContentType = "application/xml";
            request.ContentLength = 0;
            request.Headers["Ocp-Apim-Subscription-Key"] = "e1a31d39baf242a68b285267a5e44428";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string returnString = response.StatusCode.ToString();


            Console.WriteLine(returnString);


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
