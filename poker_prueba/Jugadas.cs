using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_prueba
{
    class Jugadas:Fichas
    {

        public Jugadas()
        {
            ArrayList arrJugada = new ArrayList();
            Fichas f = new Fichas();
            
        }
        

        
        public void apuestaMinima() {
            this.apuesta = this.apuesta + 1;
            this.creditos = this.creditos - 1;
            
        }
        public void apuestaMaxima()
        {
            this.creditos = this.creditos + this.apuesta;
            this.creditos = this.creditos - 5;
            this.apuesta = 5;

        }
        public void deal()
        {

        }

    }
}
