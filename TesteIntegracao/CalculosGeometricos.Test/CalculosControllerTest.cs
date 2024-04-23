
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace CalculosGeometricos.Test
{
    public class CalculosControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public CalculosControllerTest(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = $"https://localhost:7195/Calculos/quadrado?numero={2}";

            // Act
            var response = await client.GetAsync(url);

            // Assert
            var resultado = response.Content.ReadAsStringAsync().Result;

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
