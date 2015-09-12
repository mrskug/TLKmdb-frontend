using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;


namespace TLKmdb_frontend
{
    class Request
    {

        // string for json response
        public string response;

        // Constructor with logindetails and json request string
        public Request(string url, string user, string pass, string requestJson, string type)
        {
            // HTTP Client
            HttpClient client = new HttpClient();

            // Authentication
            string base64cred = Convert.ToBase64String(
                Encoding.UTF8.GetBytes(user + ":" + pass));

            // Set address
            client.BaseAddress = new Uri("http://" + url);

            // Set default headers
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", base64cred);
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

            if (type == "POST")
            {
                // Set content
                HttpContent content = new StringContent(requestJson);

                // Accept application/json
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Make the http request
                try
                {
                    HttpResponseMessage httpResponse = client.PostAsync(client.BaseAddress, content).Result;
                    httpResponse.EnsureSuccessStatusCode();
                    response = httpResponse.Content.ReadAsStringAsync().Result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (type == "GET")
            {
                // Set content
                HttpContent content = new StringContent(requestJson);

                // Accept application/json
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Make the http request
                try
                {
                    HttpResponseMessage httpResponse = client.GetAsync(client.BaseAddress).Result;
                    httpResponse.EnsureSuccessStatusCode();
                    response = httpResponse.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(response);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (type == "DELETE")
            {
                Console.WriteLine("DELETE Not implemented!");
            }
            else if (type == "PATCH")
            {
                Console.WriteLine("PATCH Not implemented!");
            }
            else
            {
                Console.WriteLine("No Type Specified!!");
            }

        }
    }
}
