using AutomationAPI.Demo;
using AutomationAPI.DTO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APITests.Steps
{
    [Binding]
    public class Authorization
    {

        [Given(@"I have an Identity Jwt")]
        public void GivenIHaveAnIdentityJwt()
        {
            var restClient = new RestClient("https://staffid.domain.co.nz/staffidentityprovider/v1/identity");
            var encodedPasswordInBytes = Convert.FromBase64String("U2VhcmNoQDEyMzQ1Njc=");
            string decodedPassword = Encoding.UTF8.GetString(encodedPasswordInBytes);
            Console.WriteLine(decodedPassword);
            restClient.Authenticator = new HttpBasicAuthenticator("branch\\DEV.GopaD", decodedPassword);
            var restRequest = new RestRequest(Method.GET);
            IRestResponse response = restClient.Execute(restRequest);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                StaffIdentityDTO DTO = JsonConvert.DeserializeObject<StaffIdentityDTO>(response.Content);
                Console.WriteLine("Bearer " + DTO.IdentityJwt);
                Console.WriteLine("Login Successful");
            }
            
        }

        [Given(@"I have a Consumer JWT for TestConsumer")]
        public void GivenIHaveAConsumerJwt()
        {
                    }

        [Given(@"I have a GetCase URL")]
        public void GivenIHaveAGetCaseURL(Table table)
        {
            var user = new APIHelper<GetHLECaseResponseDTO>();
            var dictionary = TableExtensions.ToDictionary(table);
            var test = dictionary["Endpoint"];
            //foreach (TableRow t in table.Rows)
            //{
            //    url = user.SetUrl(t["EndPoint"]);
            //    Thread.Sleep(1000);
            //}
            //var url = user.SetUrl(test);
            //var request = user.CreateGetRequest();
            //var response = user.GetResponse(url, request);
            //GetHLECaseResponseDTO content = user.GetContent<GetHLECaseResponseDTO>(response);
            // return content;

        }

        [Given(@"I set query string with below parameters")]
        public void GivenISetQueryStringWithBelowParameters(Table table)
        {
            
        }

        [When(@"I make a GET request")]
        public void WhenIMakeAGETRequest()
        {
           
        }

        [Then(@"the response status code should be OK")]
        public void ThenTheResponseStatusCodeShouldBeOK()
        {
            
        }

    }
}
