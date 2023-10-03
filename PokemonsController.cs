using Microsoft.AspNetCore.Mvc;
using Pokedex.API.Models;
using Pokedex.API.Services;

namespace Pokedex.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonsController : ControllerBase
    {
        private readonly ILogger<PokemonsController> _logger;

        public PokemonsController(ILogger<PokemonsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Pokemon> Get()
        {
            List<Pokemon> pokemons = null;
            PokemonService pokemonService = null;

            try
            {
                pokemonService = new PokemonService();
                pokemons = pokemonService.SelectPokemons();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return pokemons;

        }
    }
}