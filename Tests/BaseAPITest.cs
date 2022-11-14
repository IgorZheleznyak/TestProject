using Core.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace Tests
{
    public class BaseAPITest
    {
        protected RestClient? client;
        protected User? user;

        [SetUp]
        public void Setup()
        {
            LoadUserData();

            if (user is null) throw new NullReferenceException();
            if (user.ApiKey is null) throw new NullReferenceException();
            if (user.Token is null) throw new NullReferenceException();

            client = new RestClient("https://trello.com/")
            {
                Authenticator = OAuth1Authenticator.ForProtectedResource(user.ApiKey, "", user.Token, "")
            };
        }

        [TearDown]
        public void Teardown()
        {
        }

        private void LoadUserData()
        {
            using StreamReader reader = new("users.json");
            string json = reader.ReadToEnd();
            user = JsonConvert.DeserializeObject<User>(json);
        }
    }
}
