using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace _3shape_challenge
{
    public class Challenge
    {
        static void Main(string[] args)
        {
            var token = GetUserInput(args);
            var json = GetRateFromGitHub(token);
            var comparison = DeserializeAndCompare(json);
            if (comparison <= 10)
            {
                Console.WriteLine("You are equal or below 10%");
                Environment.Exit(1);
            };
        }

        public static string GetUserInput(string[] input)
        {
            return input[0];
        }
        public static string GetRateFromGitHub(string token)
        {
            var request = HttpWebRequest.Create("https://api.github.com/rate_limit");
            request.Headers.Add(HttpRequestHeader.Accept, "application/vnd.github.v3+json");
            request.Headers.Add(HttpRequestHeader.UserAgent, "usertest");
            request.Headers.Add(HttpRequestHeader.Authorization, "token " + token);
            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);
            var jsonResponse = reader.ReadToEnd();
            return jsonResponse;
        }
        public static decimal DeserializeAndCompare(string obj)
        {
            dynamic Obj = JsonConvert.DeserializeObject(obj);
            int remaining = Obj.rate.remaining;
            int limit = Obj.rate.limit;
            decimal compare = (100 * remaining) / limit;
            return compare;
        }
    }
}
