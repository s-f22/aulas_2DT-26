using System;
using System.Collections.Generic;

namespace GestaoJogosEFCore.Models;

public partial class Jogador
{
    public int IdJogador { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public virtual ICollection<JogadorJogo> JogadorJogo { get; set; } = new List<JogadorJogo>();

    public virtual PerfilJogador? PerfilJogador { get; set; }
}
