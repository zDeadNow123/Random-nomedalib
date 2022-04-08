using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_nomedalib_ {
    public class Pedido {

        // idped data status_ped desconto idcli_ped iduser_ped
        // Atributos

        // Propriedades
        public int Id { get; set; }
        public DateTime dataPed { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        // Construtores
        public Pedido() {
        }

        public Pedido(int Id, DateTime dataPed, string Status, double Desconto, Cliente Cliente, Usuario Usuario, List<ItemPedido> Itens) {
            this.Id = Id;
            this.dataPed = dataPed;
            this.Status = Status;
            this.Desconto = Desconto;
            this.Cliente = Cliente;
            this.Usuario = Usuario;
            this.Itens = Itens;
        }

        // Métodos da classe
        public void Inserir() {

        }

        public bool Alterar(Pedido pedido) {
            return false;
        }

        public static Pedido ConsultarPorId(int _id) {
            return new Pedido();
        }

        // Consultar por Cliente Id
        public static List<Pedido> ConsultarPorClienteId(int _id) {
            return new List<Pedido>();
        }

    }
}
