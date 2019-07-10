using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SampleCallRestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Account
            string Response = string.Empty;
            string url = "https://wsx.sp247.net/sms/send";
            string username = "";
            string password = "";

            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            var json = JsonConvert.SerializeObject(new LinkRequest());

            using (var client = new WebClient())
            {
                client.Headers.Add("Authorization", "Basic " + svcCredentials);
                client.Headers.Add("Content-Type", "application/json");
                Response = client.UploadString(url, "POST", json);
            }

            Console.WriteLine(Response);

        }
    }
}
