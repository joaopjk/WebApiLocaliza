using Api.DTO;
using FluentAssertions;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using XUnitTest_API.Fixtures;

namespace XUnitTest_API.Scenarios
{
    public class DecomporNumeroTest
    {
        private readonly TestContext _testContext;
        public DecomporNumeroTest()
        {
            _testContext = new TestContext();
        }
        [Fact]
        public async Task Values_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("API/v1/DecomporNumero/2");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Fact]
        public async Task Values_Get_ReturnsBadRequestResponse()
        {
            var response = await _testContext.Client.GetAsync("API/v1/DecomporNumero/XXX");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
        [Fact]
        public async Task Values_Get_CorrectContentType()
        {
            var response = await _testContext.Client.GetAsync("API/v1/DecomporNumero/5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
        }
        [Fact]
        public async Task Values_Get_ReturnsOkResponse_WithResults_Request90()
        {
            var response = await _testContext.Client.GetAsync("API/v1/DecomporNumero/90");
            response.EnsureSuccessStatusCode();
            var stringResponse = response.Content.ReadAsStringAsync().Result;
            var retorno = JsonConvert.DeserializeObject<DecomporNumeroResponse>(stringResponse);
            Assert.Equal(3, retorno.divisoresPrimos.Count);
            Assert.Equal(12, retorno.divisores.Count);
        }
        [Fact]
        public async Task Values_Get_ReturnsBadRequestResponse_Request0()
        {
            var response = await _testContext.Client.GetAsync("API/v1/DecomporNumero/0");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
