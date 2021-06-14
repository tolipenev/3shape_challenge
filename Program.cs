using System;
using System.IO;
using System.Net;

namespace _3shape_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = GetUserInput(args);
            GetRateFromGitHub(token);
        }

        static string GetUserInput(string[] input)
        {
            return input[0];
        } 
        static void GetRateFromGitHub(string token)
        {
            var request = HttpWebRequest.Create("https://api.github.com/rate_limit");
            request.Headers.Add(HttpRequestHeader.Accept, "application/vnd.github.v3+json");
            request.Headers.Add(HttpRequestHeader.UserAgent, "usertest");
            var responce = request.GetResponse();
            var stream = responce.GetResponseStream();
            var reader = new StreamReader(stream);
            var dataread = reader.ReadToEnd();

        }
        
    }
}
