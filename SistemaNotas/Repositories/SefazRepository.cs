using Microsoft.EntityFrameworkCore;
using SistemaNotas.Context;
using SistemaNotas.Interfaces;
using SistemaNotas.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaNotas.Repositories
{
    public class SefazRepository : ISefazRepository
    {
        private readonly AppDbContext _context;

        public SefazRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sefaz>> ObterTodos()
        {
            return await _context.Sefazs.ToListAsync();
        }

        public async Task Adicionar(Sefaz entidades)
        {
            await _context.Sefazs.AddAsync(entidades);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Deletar(int id)
        {
            var del = await _context.Sefazs.SingleOrDefaultAsync(d => d.SefazId.Equals(id));
            if (del == null)
                return false;
            _context.Remove(del);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Sefaz> Editar(int Id)
        {
            return await _context.Sefazs.SingleOrDefaultAsync(e => e.SefazId.Equals(Id));
        }

        public async Task<Sefaz> Update(Sefaz sefaz)
        {
            var up = await _context.Sefazs.SingleOrDefaultAsync(u => u.SefazId.Equals(sefaz.SefazId));
            if (up == null)

                return null;
            _context.Entry(up).CurrentValues.SetValues(sefaz);
            await _context.SaveChangesAsync();

            return sefaz;
        }

       
    }
}
