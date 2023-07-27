using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonTamagotchi.Interfaces;
using PokemonTamagotchi.Models;
using System.Text.Json;

namespace PokemonTamagotchi.Services
{
    public class PokemonModelService : IPokemonModelService
    {
        private readonly HttpClient _httpClient;
        public PokemonModelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        string apiUrl = "https://pokeapi.co/api/v2/pokemon/";

        [HttpGet]
        public IEnumerable<Pokemon> GetAll()
        {
            HttpResponseMessage response = _httpClient.GetAsync(apiUrl).Result;
            try
            {
                var pokemonJson = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<IEnumerable<Pokemon>>(pokemonJson);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public Pokemon Get(int id)
        {
            HttpResponseMessage response = _httpClient.GetAsync(apiUrl + $"/{id}").Result;

            try
            {
                var pokemonJson = response.Content.ReadAsStringAsync().Result;
                Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(pokemonJson);
                return pokemon;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }

        /*[HttpPost]
        public Pokemon Insert(Pokemon pokemon)
        {
            var entity = _mapper.Map<Pokemon>(pokemon);
            _context.Pokemons.Insert(entity);
        }*/
    }
}
