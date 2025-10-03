using WebApi8_EF.Dto.Vinculo;
using WebApi8_EF.Models;

namespace WebApi8_EF.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
