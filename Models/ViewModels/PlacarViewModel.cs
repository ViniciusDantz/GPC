using System.Collections.Generic;

namespace GPC.Models.ViewModels
{   
    public class PlacarViewModel
    {
        public Placar Placar { get; set; }
        public List<Jogador> Jogadores { get; set; }
    }
}