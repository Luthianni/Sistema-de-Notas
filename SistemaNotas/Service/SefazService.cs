using AutoMapper;
using SistemaNotas.DTOs;
using SistemaNotas.Interfaces;
using SistemaNotas.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaNotas.Service
{
    public class SefazService : ISefazService
    {
        private readonly IMapper mapper;
        private readonly ISefazRepository repository;

        public SefazService(IMapper mapper, ISefazRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task AddAsync(SefazDTO sefazDTO)
        {
            var entidade = mapper.Map<Sefaz>(sefazDTO);
            await repository.Adicionar(entidade);
        }

        public async Task<IEnumerable<SefazDTO>> GetAllAsync()
        {
            var notas = await repository.ObterTodos();
            var notasVM = mapper.Map<IEnumerable<SefazDTO>>(notas);

            return notasVM;
        }

        public async Task<SefazDTO> GetByIdAsync(int Id)
        {
            var sefaz = await repository.Editar(Id);
            var entidade = mapper.Map<SefazDTO>(sefaz);
            return entidade;
        }

        public async Task<SefazDTO> UpdateAsync(SefazDTO sefaz)
        {
            var UpSefaz = mapper.Map<Sefaz>(sefaz);
            await repository.Update(UpSefaz);
            var SefazUp = mapper.Map<SefazDTO>(UpSefaz);

            return SefazUp;
        }

        public async Task<bool> Delete(int id)
        {
            return await repository.Deletar(id);
        }
    }
}
