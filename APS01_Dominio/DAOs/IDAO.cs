using APS01_Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APS01_Dominio.DAOs
{
    public interface IDAO<T> where T : Model
    {
        void Inserir(T obj);

        void Remover(T obj);

        void Atualizar(T obj);

        T RetornarPorId(string id);

        List<T> RetornarTodos();
    }
}
