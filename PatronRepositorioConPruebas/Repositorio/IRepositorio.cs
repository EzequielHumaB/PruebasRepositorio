using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace PatronRepositorioConPruebas.Repositorio
{
   public interface IRepositorio <T> where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> expression);
        T Buscar(int id);
        bool Guardar(T entity);
        bool Eliminar(int id);
        bool Modificar(T entity);
   
    }
}
