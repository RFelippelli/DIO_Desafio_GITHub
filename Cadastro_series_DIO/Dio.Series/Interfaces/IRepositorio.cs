using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();
    }
}