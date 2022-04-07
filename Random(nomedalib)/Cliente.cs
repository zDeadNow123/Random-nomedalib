using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_nomedalib_ {
    public class Cliente {

        // atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value;} }
        public string Email { get { return email; } set { email = value; } }
        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }


        // construtores
        public Cliente() {
        }

        public Cliente(string nome, string cpf, string email) {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }

        // métodos de classe
        public static void Inserir(Cliente cliente) {

        }

        public bool Alterar() {
            return true;
        }

        public static Cliente ConsultarPorId(int _id) {
            Cliente cliente = new Cliente();
            // cena dos próximos episódios...
            return cliente;
        }



    }

}
