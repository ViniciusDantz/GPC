using GPC.Models;
using GPC.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPC.Services
{
    public class PlacarService
    {
        private GPC_Context _context;

        public PlacarService(GPC_Context context)
        {
            _context = context;
        }

        public async Task InsertAsync(Placar obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Placar>> FindAllAsync()
        {
            return await _context.Placar.ToListAsync();
        }

        public async Task<Placar> FindByIdAsync(int id)
        {
            return await _context.Placar.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task UpdateAsync(Placar Placar)
        {
            if(!_context.Placar.Any(obj => obj.Id == Placar.Id)){
                throw new NotFoundException("Id não foi encontrado, esse Placar pode não estar cadastrado.");
            }

            try
            {
                _context.Update(Placar);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Placar.FindAsync(id);
                _context.Placar.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
