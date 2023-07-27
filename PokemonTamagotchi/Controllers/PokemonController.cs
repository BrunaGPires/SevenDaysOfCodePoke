using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokemonTamagotchi.Interfaces;
using PokemonTamagotchi.Models;
using System.Net.Http;
using System.Text.Json;

namespace PokemonTamagotchi.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonModelService _pokemonModelService;
        public PokemonController(IPokemonModelService pokemonModelService)
        {
            _pokemonModelService = pokemonModelService;
        }
        
        // GET: Clients
        public ActionResult Index()
        {
            return View(_pokemonModelService.GetAll());
        }

        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }

            Pokemon pokemon = _pokemonModelService.Get(id.Value);
            return View(pokemon);
        }

        
    }
}
