using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public uint Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Por favor, insira o nome do tipo")]
        public string Nome { get; set; }

        [StringLength(25)]
        public string Cor { get; set; } = "rgba(0, 0, 0, 1)";

        public List<PokemonTipo> Pokemons { get; set; }
    }
}