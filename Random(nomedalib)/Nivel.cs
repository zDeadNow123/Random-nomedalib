using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_nomedalib_ {
    public class Nivel {

        // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        public readonly bool ativo;

        // criando propriedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Sigla { get { return Sigla; } }


        // metodos construtores
        public Nivel() {
        }

        public Nivel(string nome, string sigla) {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;
        }

        public Nivel(int id, string nome, string sigla, bool ativo) {
            
            this.id = id;
            this.nome = nome;
            this.sigla= sigla;
            this.ativo = true;
        }

        // metodos da classe
        public void InserirNovo() { 
            
            // inserir um novo nivel
        }

        /// <summary>
        /// Altera a sigla do nivel indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">Identificação do nível</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor para teste lógico, confirmando a alteração</returns>
        public bool Alterar(int id, string sigla) {
            return true;
        }

    }
}
