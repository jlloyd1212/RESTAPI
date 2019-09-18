using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPITesting
{
    public class RESTAPIHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string endpoint = "http://mydomain.com";

        public static RestClient SetURL()
        {
            var URL = endpoint;
            return client = new RestClient(URL);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
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
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest CreateRequest2(string userid, long accountNumber)
        {
            var resource = userid + "/AccountInformation?account={accountNumber}";
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddParameter("accountNumber", accountNumber, ParameterType.UrlSegment);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest CreatePostRequest()
        {
           // int inputDate = 1984-1-8;
            var userInfo = new UserInformation();
            userInfo.FirstName = "Samuel";
            userInfo.LastName = "Salome";
            userInfo.EmailAddress= "jlloydsamuel1212@yahoo.com";
            //userInfo.DateOfBirth = new DateTime(inputDate).ToLongDateString();

            var resource = "/registration/";
            restRequest = new RestRequest(resource, Method.POST);
            restRequest.AddJsonBody(userInfo);
            restRequest.AddHeader("Accept","application/json");
            return restRequest;
        }
    }
}