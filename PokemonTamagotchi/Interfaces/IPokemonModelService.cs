using PokemonTamagotchi.Models;

namespace PokemonTamagotchi.Interfaces
{
    public interface IPokemonModelService
    {
        Pokemon Get(int id);
        IEnumerable<Pokemon> GetAll();
    }
}
