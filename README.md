# Sample_APIM_Request_Test
it's a sample ajax test for APIM Request, test the Cross Domain issue.

follow is the code example :


JQUERY AJAX:

        $.ajax({
            url: 'https://api-service-demo-01.azure-api.cn/apim/api/values',
            headers: {
                'Access-Control-Allow-Origin': '*',
                'Ocp-Apim-Subscription-Key': 'e1a31d39baf242a6dfsda5e4442dfd8',
                'Content-Type': 'application/json'
            },
            method: 'PUT',
            dataType: 'json',
            success: function (data) {
                alert('succes: ' + data);
            }
        });

C#:

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
