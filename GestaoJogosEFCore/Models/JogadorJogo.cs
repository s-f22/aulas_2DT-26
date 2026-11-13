using System;
using System.Collections.Generic;

namespace GestaoJogosEFCore.Models;

public partial class JogadorJogo
{
    public int IdJogadorJogo { get; set; }

    public int IdJogador { get; set; }

    public int IdJogo { get; set; }

    public DateOnly DataAquisicao { get; set; }

    public decimal HorasJogadas { get; set; }

    public string Status { get; set; } = null!;

    public virtual Jogador IdJogadorNavigation { get; set; } = null!;

    public virtual Jogo IdJogoNavigation { get; set; } = null!;
}
