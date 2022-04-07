using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_nomedalib_ {
    public class Produto {

        // atributos
        private int id;
        private string descricao;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;


        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string Codbar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }

        // construtores
        public Produto() {
        }

        public Produto(string descricao, string unidade, string codbar, int valor, int desconto) {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
        }

        // métodos de classe
    }
}
