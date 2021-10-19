using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosGama{

    class Animais{
        private string nome;
        private string tipo;

        public string getNome(){
            return this.nome;
        }
        public void setNome(string nome){
            this.nome = nome;
        }
        public string getTipo(){
            return this.tipo;
        }
        public void setTipo (string tipo){
            if (tipo == "gato" || tipo == "cachorro"){
                this.tipo = tipo;
            } else {
                this.tipo = "peixe";
            }
        }
    }
}