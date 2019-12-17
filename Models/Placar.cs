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
        [DisplayFormat(DataFormatString = "{0:DD/MM/AAAA}")]
        public DateTime Data { get; set; }
    }
}