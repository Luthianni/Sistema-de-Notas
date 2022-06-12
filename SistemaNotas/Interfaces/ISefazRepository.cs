using SistemaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Interfaces
{
   public interface ISefazRepository
    {
        Task<IEnumerable<Sefaz>> ObterTodos();

        Task Adicionar(Sefaz entidades);

        Task<Sefaz> Editar(int id);

        Task<Sefaz> Update(Sefaz sefaz);

        Task<bool> Deletar(int id);
    }
}
