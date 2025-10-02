using Microsoft.EntityFrameworkCore;
using WebApi8_EF.Data;
using WebApi8_EF.Models;

namespace WebApi8_EF.Services.Autor
{
    public class AutorService : IAutorInterface
    {
        private readonly AppDbContext _context;

        public AutorService (AppDbContext context)
        {
            _context = context; 
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<AutorModel>>> ListarAutores()
        {
            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();
            try
            {
                var autores = await _context.Autores.ToListAsync();
                if (autores == null || autores.Count == 0)
                {
                    resposta.Mensagem = "Nenhum autor encontrado.";
                    resposta.Status = true;
                    return resposta;
                }
                resposta.Dados = autores;
                resposta.Mensagem = "Autores encontrados com sucesso.";
                resposta.Status = true;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;

            }
        }
    }
}
