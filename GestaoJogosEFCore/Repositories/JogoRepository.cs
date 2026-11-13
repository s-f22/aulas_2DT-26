
using GestaoJogosEFCore.Data;
using GestaoJogosEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoJogosEFCore.Repositories
{

    public class JogoRepository
    {
        private readonly DbContextOptions<GestaoJogosContext> _options;

        public JogoRepository(DbContextOptions<GestaoJogosContext> options)
        {
            _options = options;
        }

        public List<Jogo> Listar()
        {
            using var context = new GestaoJogosContext(_options);
        }


    }
}