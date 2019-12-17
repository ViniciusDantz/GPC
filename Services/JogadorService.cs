using GPC.Models;
using GPC.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPC.Services
{
    public class JogadorService
    {
        private GPC_Context _context;

        public JogadorService(GPC_Context context)
        {
            _context = context;
        }

        public async Task InsertAsync(Jogador obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Jogador>> FindAllAsync()
        {
            return await _context.Jogador.ToListAsync();
        }

        public async Task<Jogador> FindByIdAsync(int id)
        {
            return await _context.Jogador.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task<bool> ExistEqual(Jogador Jogador){
            var atvd = await _context.Jogador.Where(obj => obj.Nome == Jogador.Nome).SingleOrDefaultAsync();
            if(atvd != null){
                return true;
            }
            return false;
        }

        public async Task UpdateAsync(Jogador Jogador)
        {
            if(!_context.Jogador.Any(obj => obj.Id == Jogador.Id)){
                throw new NotFoundException("Id não foi encontrado, esse(a) Jogador(a) pode não estar cadastrado(a).");
            }

            try
            {
                _context.Update(Jogador);
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
                var obj = await _context.Jogador.FindAsync(id);
                _context.Jogador.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
