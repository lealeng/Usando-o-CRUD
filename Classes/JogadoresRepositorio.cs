using System;
using System.Collections.Generic;
using CRUD.Interfaces;

namespace CRUD
{
    public class JogadoresRepositorio : IRepositorio<Jogadores>
    {
        private List<Jogadores> listaJogadores = new List<Jogadores>();
        public void Atualizar(int id, Jogadores objeto)
        {
            listaJogadores[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaJogadores[id].Excluir();
        }

        public void Inserir(Jogadores objeto)
        {
            listaJogadores.Add(objeto);
        }

        public List<Jogadores> Lista()
        {
            return listaJogadores;
        }

        public int ProximoId()
        {
            return listaJogadores.Count;
        }

        public Jogadores RetornarPorId(int id)
        {
            return listaJogadores[id];
        }
    }
}
