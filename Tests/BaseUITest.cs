using Core.Models;
using Core.Setup;
using Newtonsoft.Json;

namespace Tests
{
    public class BaseUITest
    {
        protected DriverManager driverManager;
        protected User? user;

        [SetUp]
        public void Setup()
        {
            LoadUserData();
            driverManager = new();
        }

        [TearDown]
        public void Teardown()
        {
            driverManager.StopDriver();
        }

        private void LoadUserData()
        {
            using StreamReader reader = new("users.json");
            string json = reader.ReadToEnd();
            user = JsonConvert.DeserializeObject<User>(json);
        }
    }
}
