using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class libreria
    {
        string nomeLibreria;
        string indirizzo;
        int apertura;
        int chiusura;
        List<Libro> elencoLibri;
        public libreria(string nomeLibreria, string indirizzo, int apertura, int chiusura)
        {
            this.nomeLibreria = nomeLibreria;
            this.indirizzo = indirizzo;
            this.apertura = apertura;
            this.chiusura = chiusura;
        }

        public void aggiuntaLibro(Libro libro)
        {
            elencoLibri.Add(libro);
        }

        public string GetLibro(string titolo)
        {
            foreach (var libro in elencoLibri)
            {
                if(libro.getTitolo() == titolo)
                {
                    return libro.toString();
                }     
            }
                return "non abbiamo quel libro";
        }
        public string GetLibri(string autore)
        {
            string output = "";
            foreach (var libro in elencoLibri)
            {
                if (libro.getTitolo() == autore)
                {
                  output += libro.toString() + "\n";
                }
            }
            return "non abbiamo libri di quell'autore";
        }
    }
}
