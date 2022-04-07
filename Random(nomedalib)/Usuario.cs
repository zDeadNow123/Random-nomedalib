using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_nomedalib_ {

    // Documentaçâo de classes de projeto. - XML Docs
    public class Usuario {

        // atributos
        private int id;
        private string nome;
        private string email;
        private Nivel nivel;
        private string password;
        private bool ativo = true;

        // propriedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } }
        public string Email { get { return email; } }
        public string Password { get { return password; } }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        // métodos construtores
        public Usuario() {
        }

        public Usuario(string nome, string email, string password, Nivel nivel) {
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel;
        }

        public Usuario(int id, string nome, string email, string password, Nivel nivel, bool ativo) {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel;
            this.ativo = ativo;
        }

        // métodos da classe
        public int Inserir() {
            return id;   
        }

        public static bool EfetuarLogin(string email, string senha) {

            return false;
        }

    }
}
