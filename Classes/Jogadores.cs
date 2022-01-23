using System;

namespace CRUD
{
    public class Jogadores : Pessoas
    {
        private Posicoes Posicoes { get; set; }
        private string Time { get; set; }
        private int Numero { get; set; }
        private bool Excluido { get; set; }

        public Jogadores(int id, string nome, string cpf, int idade, Posicoes posicoes, string time, int numero)
        {
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.Idade = idade;
            this.Posicoes = posicoes;
            this.Time = time;
            this.Numero = numero;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Ordem do Cadastro: " + this.Id + Environment.NewLine;
            retorno += "Nome do Jogador: " + this.Nome + Environment.NewLine;
            retorno += "CPF do Jogador: " + this.CPF + Environment.NewLine;
            retorno += "Idade do Jogador: " + this.Idade + Environment.NewLine;
            retorno += "Posição do jogador: " + this.Posicoes + Environment.NewLine;
            retorno += "Nome do Time: " + this.Time + Environment.NewLine;
            retorno += "Número da Camisa: " + this.Numero + Environment.NewLine;
            retorno += "Status do cadastro: " + this.Excluido + Environment.NewLine;

            return retorno;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public string retornaNomeJogador()
        {
            return this.Nome;
        }
        public int retornaNumeroCamisa()
        {
            return this.Numero;
        }
        public Posicoes retornaPosicaoJogador()
        {
            return this.Posicoes;
        }
        public string retornaTimeJogador()
        {
            return this.Time;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}