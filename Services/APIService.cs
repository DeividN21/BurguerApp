using BurguerApp.Models;
using BurguerApp.Models.Catalogos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurguerApp.Services
{
    public class APIService
    {
        public static string _baseUrl;
        public HttpClient _httpClient;

        public APIService()
        {

            _baseUrl = "https://apirestaurantehamburguesas20231128183324.azurewebsites.net";
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }

        public async Task<Cliente> InicioSesion(string nombreUsuario, string password)
        {
            var response = await _httpClient.GetAsync($"/api/Usuario/IncioSesionCliente/{nombreUsuario},{password}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Cliente>();
            }

            return null;
        }

        public async Task<List<CategoriaComida>> ObtenerCategoriaComida(int idCategoriaComida)
        {
            var response = await _httpClient.GetAsync($"/api/Producto/ObtenerCategoriaComida/{idCategoriaComida}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<CategoriaComida>>();
            }

            return null;
        }

        public async Task<List<CategoriaCombo>> ObtenerCategoriaCombo(int idCategoriaCombo)
        {
            var response = await _httpClient.GetAsync($"/api/Producto/ObtenerCategoriaComida/{idCategoriaCombo}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<CategoriaCombo>>();
            }

            return null;
        }

        public async Task<List<Comida>> ObtenerComidas()
        {
            var response = await _httpClient.GetAsync("/api/Producto/ObtenerComidas");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Comida> productos = JsonConvert.DeserializeObject<List<Comida>>(json_response);
                return productos;
            }
            return new List<Comida>();

        }

        public async Task<List<Combo>> ObtenerCombos()
        {
            var response = await _httpClient.GetAsync("/api/Producto/ObtenerCombos");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Combo> productos = JsonConvert.DeserializeObject<List<Combo>>(json_response);
                return productos;
            }
            return new List<Combo>();

        }

        public async Task<List<Comida>> FiltrarComidas(int idCategoriaComida)
        {
            var response = await _httpClient.GetAsync($"/api/Producto/FiltrarComidas/{idCategoriaComida}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Comida> productos = JsonConvert.DeserializeObject<List<Comida>>(json_response);
                return productos;
            }
            return new List<Comida>();

        }

        public async Task<List<Combo>> FiltrarCombos(int idCategoriaCombo)
        {
            var response = await _httpClient.GetAsync($"/api/Producto/FiltrarCombos/{idCategoriaCombo}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Combo> productos = JsonConvert.DeserializeObject<List<Combo>>(json_response);
                return productos;
            }
            return new List<Combo>();

        }
    }
}
