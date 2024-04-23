
using CalculosGeometricos.ViewModel;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
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
        public async Task Get_QuadradoComSucesso()
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

        [Fact]
        public async Task Post_SomaComSucesso()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = $"https://localhost:7195/Calculos/soma";
            var numeros = new SomaViewModel { 
                Numero1 = 1,
                Numero2 = 2,
            };

            string numerosJson = JsonConvert.SerializeObject(numeros);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage { 
                Method = HttpMethod.Post,
                Content = new StringContent(numerosJson,System.Text.Encoding.UTF8,"application/json"),
                RequestUri = new Uri(url)
            };
            // Act
            var response = await client.SendAsync(httpRequestMessage);

            // Assert
            var resultado = response.Content.ReadAsStringAsync().Result;

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Post_PotenciaComSucesso()
        {
            // Arrange
            var client = _factory.CreateClient();
            var url = $"https://localhost:7195/Calculos/potencia";
            var numeros = new PotenciaViewModel
            {
                numero = 2,
                expoente = 2,
            };

            string numerosJson = JsonConvert.SerializeObject(numeros);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(numerosJson, System.Text.Encoding.UTF8, "application/json"),
                RequestUri = new Uri(url)
            };
            // Act
            var response = await client.SendAsync(httpRequestMessage);

            // Assert
            var resultado = response.Content.ReadAsStringAsync().Result;

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
