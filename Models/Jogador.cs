using System.ComponentModel.DataAnnotations;

namespace GPC.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }
    }
}