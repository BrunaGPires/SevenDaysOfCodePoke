using System.Text.Json.Serialization;

namespace PokemonTamagotchi.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("weight")]
        public long Weight { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("species")]
        public Species Species { get; set; }

        [JsonPropertyName("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonPropertyName("moves")]
        public List<Move> Moves { get; set; }

        [JsonPropertyName("stats")]
        public List<Stat> Stats { get; set; }
    }

    public partial class Species
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public partial class Ability
    {
        [JsonPropertyName("ability")]
        public Species AbilityAbility { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("slot")]
        public long Slot { get; set; }
    }

    public partial class Move
    {
        [JsonPropertyName("move")]
        public Species MoveMove { get; set; }
    }

    public partial class Stat
    {
        [JsonPropertyName("base_stat")]
        public long BaseStat { get; set; }

        [JsonPropertyName("effort")]
        public long Effort { get; set; }

        [JsonPropertyName("stat")]
        public Species StatStat { get; set; }
    }
}
