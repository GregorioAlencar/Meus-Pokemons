using Pokedex.API.Models;
using Pokedex.API.Repositories;

namespace Pokedex.API.Services
{
    public class PokemonService
    {

        public PokemonService() { } 

        public List<Pokemon> SelectPokemons () {
            PokemonRepository pokemonRepository = null;
            List<Pokemon> pokemons = null;

            try
            {
                pokemonRepository = new PokemonRepository();
                pokemons = pokemonRepository.SelectPokemons();
            }
            catch (Exception exception) 
            {
                throw exception;
            }

            return pokemons;
        }
    }
}
