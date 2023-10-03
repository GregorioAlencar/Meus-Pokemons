using Pokedex.API.Models;

namespace Pokedex.API.Repositories
{
    public class PokemonRepository
    {
        public List<Pokemon> SelectPokemons()
        {
            List<Pokemon> pokemons = null;
            Pokemon pokemon = null;

            try
             {   
                pokemons = new List<Pokemon>();

                pokemon = new Pokemon();
                pokemon.Id = 1;
                pokemon.Name = "Picachu";
                pokemon.Description = "Raro";
                pokemon.Type = "Eletrico";

                pokemons.Add(pokemon);

                pokemon = new Pokemon();
                pokemon.Id = 2;
                pokemon.Name = "Charizard";
                pokemon.Description = "Dragão";
                pokemon.Type = "Fogo";

                pokemons.Add(pokemon);

                pokemon = new Pokemon();
                pokemon.Id = 3;
                pokemon.Name = "Charmander";
                pokemon.Description = "Filhote";
                pokemon.Type = "Água";

                pokemons.Add(pokemon);

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return pokemons;

        }

    }
}
