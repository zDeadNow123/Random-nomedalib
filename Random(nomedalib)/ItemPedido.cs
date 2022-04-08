using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_nomedalib_ {
    public class ItemPedido {

        // idped_ip idprod_ip valor quantidade desconto
        // Atributos
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;

        // Propriedades
        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }

        // Métodos da classe
        public void Inserir() {
            
        }

        public void Alterar(ItemPedido item) {

        }

        // Construtores
    }
}
