using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Base
{
    // Se encargar de guardar los datos en la API
    // abstracta para poder implementar en otras clases
    // generica para guardar una persona, producto, servicio, etc
    public abstract class BaseManager<T> where T : class
    {
        private static ProyectoWebContext contextInstance = null;

        // patron de diseño singleton se instancia una sola vez en la vida de la app
        public static ProyectoWebContext contextSingleton
        {
            get
            {
                if (contextInstance == null)
                {
                    contextInstance = new ProyectoWebContext();
                }
                return contextInstance;
            }
        }

        public abstract Task<List<T>> BuscarListaAsync();
        public abstract Task<T> BuscarAsync(T entity);
        public abstract Task<bool> Borrar(T entity);

        //Utiliza entity Framework para guardar un usuario en la base.
        public async Task<bool> Guardar(T entity, int id)
        {
            if (id == 0)
            {
                contextSingleton.Entry(entity).State = EntityState.Added;
            }
            else
            {
                contextSingleton.Entry(entity).State = EntityState.Modified;
            }

            var resultado = await contextSingleton.SaveChangesAsync() > 0;

            contextSingleton.Entry(entity).State = EntityState.Detached;
            return resultado;
        }

        public async Task<bool> Eliminar(T entity)
        {
            contextSingleton.Entry(entity).State |= EntityState.Modified;
            var resultado = await contextSingleton.SaveChangesAsync() > 0;
            return resultado;
        }
    }
}
