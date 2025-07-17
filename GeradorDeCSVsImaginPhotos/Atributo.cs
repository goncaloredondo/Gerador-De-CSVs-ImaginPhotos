using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GData
{
    internal class Atributo
    {
        private string nome;
        private string valor;

        public string Nome { get => nome; set => nome = value; }
        public string Valor { get => valor; set => valor = value; }
        public Atributo()
        {

        }
        public Atributo(string nome, string valor)
        {
            this.nome = nome;
            this.valor = valor;
        }
    }
}
