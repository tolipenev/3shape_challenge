using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace _3shape_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = GetUserInput(args);
            var json = GetRateFromGitHub(token);
            var comparison = DeserializeAndCompare(json);
            if (comparison <= 10) Console.WriteLine(1);
            else Console.WriteLine(0);
        }

        static string GetUserInput(string[] input)
        {
            return input[0];
        }
        static string GetRateFromGitHub(string token)
        {
            var request = HttpWebRequest.Create("https://api.github.com/rate_limit");
            request.Headers.Add(HttpRequestHeader.Accept, "application/vnd.github.v3+json");
            request.Headers.Add(HttpRequestHeader.UserAgent, "usertest");
            request.Headers.Add(HttpRequestHeader.Authorization, "token " + token);
            var responce = request.GetResponse();
            var stream = responce.GetResponseStream();
            var reader = new StreamReader(stream);
            var jsonResponce = reader.ReadToEnd();
            return jsonResponce;
        }
        static decimal DeserializeAndCompare(string obj)
        {
            dynamic Obj = JsonConvert.DeserializeObject(obj);
            int remaining = Obj.rate.remaining;
            int limit = Obj.rate.limit;
            decimal compare = (100 * remaining) / limit;
            return compare;
        }
    }
}
