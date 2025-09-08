using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint Numero { get; set; }

        [Required(ErrorMessage = "A região do pokémon é obrigatória")]
        public uint RegiaoId { get; set; }

        [ForeignKey("RegiaoId")]
        public Regiao Regiao { get; set; }


        [Required(ErrorMessage = "O gênero do pokémon é obrigatória")]
        public uint GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Por favor, insira o nome do pokémon")]
        public string Nome { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [Column(TypeName = "double(5,2)")]
        [Required(ErrorMessage = "A altura do pokémon é obrigatória")]
        public double Altura { get; set; }

        [Column(TypeName = "double(7,3)")]
        [Required(ErrorMessage = "O peso do pokémon é obrigatória")]
        public double Peso { get; set; }

        [StringLength(200)]
        public string Imagem { get; set; }

        [StringLength(200)]
        public string Animacao { get; set; }

        public List<PokemonTipo> Tipos { get; set; }
    }
}