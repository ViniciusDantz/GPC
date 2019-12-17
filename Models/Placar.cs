using System;
using System.ComponentModel.DataAnnotations;

namespace GPC.Models
{
    public class Placar
    {
        public int Id { get; set; }

        public int IdJogador { get; set; }

        [Required]
        public Jogador Jogador { get; set; }

        [Required]
        public double Pontos { get; set; }

        [Required]
        public DateTime Data { get; set; }
    }
}