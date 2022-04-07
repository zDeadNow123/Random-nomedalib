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
        public int Id { get { return id; } }
        public string Descricao { get { return descricao; } }
        public string Unidade { get { return unidade; } }
        public string Codbar { get { return codbar; } }
        public double Valor { get { return valor; } }
        public double Desconto { get { return desconto; } }

        // construtores
        public Produto() {
        }

        public Produto(int Id, string descricao, string unidade, string codbar, int valor, int desconto) {
            this.id = Id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
        }

    }
}
