using SistemaNotas.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Service
{
    public interface ISefazService
    {
        Task AddAsync(SefazDTO sefazDTO);

        Task<IEnumerable<SefazDTO>> GetAllAsync();
                
        Task<SefazDTO> GetByIdAsync(int Id);

        Task<SefazDTO> UpdateAsync(SefazDTO sefaz);

        Task<bool> Delete(int Id);
    }
}
