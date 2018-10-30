using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace apimWebApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string postUrl = @"https://api-service-demo-01.azure-api.cn/apim/api/values";

            var request = (HttpWebRequest)WebRequest.Create(postUrl);
            //request.Method = "PUT";
            request.Method = "GET";
            request.ContentType = "application/json";
            request.ContentLength = 0;
            request.Headers["Ocp-Apim-Subscription-Key"] = "e1a31d39baf242a68b285267a5e44428";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string returnString = "";
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                returnString= reader.ReadToEnd();
            }

            //string returnString = response.ContentEncoding.ToString();



            Message = returnString;
        }
    }
}
