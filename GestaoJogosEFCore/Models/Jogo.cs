using System;
using System.Collections.Generic;

namespace GestaoJogosEFCore.Models;

public partial class Jogo
{
    public int IdJogo { get; set; }

    public int IdDesenvolvedora { get; set; }

    public string Nome { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public int AnoLancamento { get; set; }

    public decimal Preco { get; set; }

    public virtual Desenvolvedora IdDesenvolvedoraNavigation { get; set; } = null!;

    public virtual ICollection<JogadorJogo> JogadorJogo { get; set; } = new List<JogadorJogo>();
}
