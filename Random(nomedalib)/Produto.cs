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
        private bool descontinuado;


        // propriedades
        public int Id { get { return id; } }
        public string Descricao { get { return descricao; } }
        public string Unidade { get { return unidade; } }
        public string Codbar { get { return codbar; } }
        public double Valor { get { return valor; } }
        public double Desconto { get { return desconto; } }
        public bool Descontinuado { get { return false; } }

        // construtores
        public Produto() {
        }

        public Produto(int Id, string descricao, string unidade, string codbar, int valor, int desconto, bool descontinuado) {
            this.id = Id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codbar = codbar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }

        public static Produto ConsultarDesconto(string descricao, int id, string codbar) {
            return new Produto(id, descricao, "", codbar, 0, 0, false);
        }

    }
}
