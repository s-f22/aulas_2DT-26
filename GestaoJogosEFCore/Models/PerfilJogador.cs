using System;
using System.Collections.Generic;

namespace GestaoJogosEFCore.Models;

public partial class PerfilJogador
{
    public int IdPerfil { get; set; }

    public int IdJogador { get; set; }

    public string Nickname { get; set; } = null!;

    public string? Plataforma { get; set; }

    public string? Biografia { get; set; }

    public virtual Jogador IdJogadorNavigation { get; set; } = null!;
}
