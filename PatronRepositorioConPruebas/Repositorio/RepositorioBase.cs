using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using PatronRepositorioConPruebas.DAL;
using System.Data.Entity;

namespace PatronRepositorioConPruebas.Repositorio
{
    public class RepositorioBase<T> : IDisposable, IRepositorio<T> where T : class
    {
        internal Contexto _contexto;
        public RepositorioBase()
        {
            _contexto = new Contexto();
        }
        
     
        public virtual bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                    paso = _contexto.SaveChanges() > 0;
                }

            }catch
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }

        public virtual bool Eliminar (int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);
                paso = _contexto.SaveChanges() > 0;
            }catch
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }

        public virtual bool Modificar(T entity)
        {
            bool paso = false;
            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;

            }catch
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }

        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
            }catch
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return entity;
        }

        public virtual List<T> GetList(Expression<Func<T,bool>>expression)
        {
            List<T> lista = new List<T>();
            try
            {
                lista = _contexto.Set<T>().Where(expression).ToList();
            }catch
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }
            return lista;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
