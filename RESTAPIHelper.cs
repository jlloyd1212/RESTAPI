using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIFramework
{
    public class RESTAPIHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseURL = "http://mydomain.com";

        public static RestClient SetURL()
        {
            var URL = baseURL;
            return client = new RestClient(URL);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept","application/json");
            return restRequest;
        }
        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }

        public static RestRequest CreateRequest1(string userid)
        {
            var resource = userid;
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddHeader("Accept","application/json");
            return restRequest;
        }
    }
}

