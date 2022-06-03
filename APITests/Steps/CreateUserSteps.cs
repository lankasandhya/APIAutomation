using AutomationAPI.Demo;
using AutomationAPI.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using RestSharp.Authenticators;
using System.Net;
using System.Text;

namespace APITests.Steps
{
    [Binding]
    public class CreateUserSteps
    {
        private const string BASE_URL = "https://reqres.in/";
        private readonly CreateUserRequestDTO createUserRequestDTO;
        public StaffIdentityDTO staffIdentityDTO;
        //private IRestResponse response;

        public CreateUserSteps(CreateUserRequestDTO createUserRequestDTO)
        {
            this.createUserRequestDTO = createUserRequestDTO;
           // _staffIdentityDTO = staffIdentityDTO;
        }

        

        [Given(@"I Input name ""(.*)""")]
        public void GivenIInputName(string name)
        {
            createUserRequestDTO.Name = name;

        }
        
        [Given(@"I Input job ""(.*)""")]
        public void GivenIInputJob(string job)
        {
            createUserRequestDTO.Job = job;
        }
        
        [When(@"I send create user request")]
        public void WhenISendCreateUserRequest()
        {
            var api = new Demo<CreateUserDTO>();
          //  response = api.createUser("api/users", createUserRequestDTO);

        }
        
        [Then(@"validate user is created")]
        public void ThenValidateUserIsCreated()
        {
            //var content = HandleContent.getContent<CreateUserDTO>(response);
            //Assert.AreEqual(createUserRequestDTO.Name, content.Name);
            //Assert.AreEqual(createUserRequestDTO.Job, content.Job);
        }
    }
}
