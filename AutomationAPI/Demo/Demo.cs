using AutomationAPI.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.Demo
{
    public class Demo<T>
    {
        public ListOfUsersDTO getUsers(string endpoint)
        {
            var user = new APIHelper<ListOfUsersDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ListOfUsersDTO content = user.GetContent<ListOfUsersDTO>(response);
            return content;


        }

        public CreateUserDTO createUser(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateUserDTO>();
            var url = user.SetUrl(endpoint);
            var jsonReq = user.Serialize(payload);
            var request = user.CreatePostRequest(jsonReq);
            var response = user.GetResponse(url, request);
            HttpStatusCode statusCode;
            statusCode = response.StatusCode;
            var code = (int)statusCode;
          //  Assert.AreEqual(200, code);

            CreateUserDTO content = user.GetContent<CreateUserDTO>(response);
            return content;

        }
    }
}
