using Core.Helpers;
using Core.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace Tests.APITests
{
    public class BoardCreationTests : BaseAPITest
    {
        public Board? board;

        [Test]
        public void BoardCreationAPI()
        {
            string boardName = RandomGenerator.GenerateString(8);

            var request = new RestRequest(new Uri("https://api.trello.com/1/boards/?name=" + boardName), Method.Post);

            if (client is null)
                throw new NullReferenceException();

            var response = client.Execute(request);

            if (response.Content is null)
                throw new NullReferenceException();

            board = JsonConvert.DeserializeObject<Board>(response.Content);

            if (board is null)
                throw new NullReferenceException();

            Assert.Multiple(() =>
            {
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(board, Is.Not.Null);
                Assert.That(board.Name, Is.EqualTo(boardName));
            });
        }
    }
}
