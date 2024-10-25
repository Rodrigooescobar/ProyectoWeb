using Data.Base;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Manager
{
    public class UsuariosManager : BaseManager<Usuario>
    {
        public override Task<bool> Borrar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Usuario> BuscarAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public override async Task<List<Usuario>> BuscarListaAsync()
        {
            return await contextSingleton.Usuarios.Where(x => x.Activo == true).ToListAsync();
        }
    }
}
