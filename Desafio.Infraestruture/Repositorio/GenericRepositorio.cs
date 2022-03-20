using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Desafio.Infraestruture.Infraestruture;
using Desafio.Infraestruture.Repositorio.Interface;

namespace Desafio.Infraestruture.Repositorio
{
    public class GenericRepositorio<T> : IGenerciRepositorio<T>, IDisposable where T : class
    {
        private readonly ProdutoContexto _db;

        public void Adicionar(T entidade)
        {
            _db.Set<T>().Add(entidade);
            Commit();
        }

        public void Atualizar(T entidade)
        {
            _db.Entry(entidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Commit();
        }

        public T Buscar(params object[] Key)
        {
            return _db.Set<T>().Find(Key);
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Deletar(int i)
        {
            var obj = Buscar(i);
            _db.Set<T>().Remove(obj);
            Commit();
        }

        public void Dispose()
        {
            if(_db != null)
            {
                _db.Dispose();
            }
        }

        public List<T> Obter(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public List<T> ObterTodos()
        {
            return _db.Set<T>().ToList();
        }

        public T Primeiro(Expression<Func<T, bool>> precate)
        {
            return _db.Set<T>().Where(precate).FirstOrDefault();
        }
    }
}
