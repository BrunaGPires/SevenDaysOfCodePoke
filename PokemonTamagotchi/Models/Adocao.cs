namespace PokemonTamagotchi.Models
{
    public class Adocao
    {
        public int PokemonId { get; set; }
        public DateTime AdoptionDate { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
