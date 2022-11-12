using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Libro
    {
        string autore;
        string titolo;
        int annoDiPubblicazione;
        string editore;
        int numeroPagine;
        

        public Libro(string autore, string titolo, int annoDiPubblicazione, string editore, int numeroPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoDiPubblicazione = annoDiPubblicazione;
            this.editore = editore;
            this.numeroPagine = numeroPagine;
        }

        public string toString()
        {

            return autore + " " + titolo + " " + annoDiPubblicazione + " " + editore + " " + numeroPagine;
        }
        public string readingTime()
        {
            if(numeroPagine < 100)
            {
                return "il tempo di lettura è 1h";
            }
            else if(numeroPagine >= 100 && numeroPagine < 200)
            {
                return "il tempo di lettura è 2h";
            }
            else
            {
                return "il tempo di lettura è più di 2h";
            }
        }
        public string getAutore()
        {
            return this.autore;
        }
        public string getTitolo()
        {
            return this.titolo;
        }
        public int getAnnoDiPubblicazione()
        {
            return this.annoDiPubblicazione;
        }
        public string getEditore()
        {
            return this.editore;
        }
        public int getNumeroPagine()
        {
            return this.numeroPagine;
        }
    }
}
