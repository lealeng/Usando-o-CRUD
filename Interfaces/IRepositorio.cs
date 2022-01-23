using System.Collections.Generic;
namespace CRUD.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornarPorId(int id);

         void Inserir(T objeto);

         void Excluir(int id);

         void Atualizar(int id, T objeto);
         
         int ProximoId();
    }
}