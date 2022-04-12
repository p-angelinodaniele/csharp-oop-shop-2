using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdottiEstesi
{
    internal class Prodotto
    {
        // ATTRIBUTI DELLA CLASSE (o superclasse se estesa)
        private int codice;
        protected string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        // COSTRUTTORE senza prezzo ed iva
        public Prodotto(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            Random random = new Random();
            codice = random.Next(100000000);
        }

        // COSTRUTTORE completo con prezzo ed iva
        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            Random random = new Random();
            codice = random.Next(100000000);
        }

       

        //-------------- GETTERS AND SETTERS di PRODOTTO ------------
        public string GetCodice()
        {
            string codiceConIlPadding;
            codiceConIlPadding = PadLeft();
            return codiceConIlPadding;
        }

        public string GetDescrizione()
        {
            return descrizione;
        }
        public double GetPrezzo()
        {
            return prezzo;
        }
        public double GetIva()
        {
            return iva;
        }
        public void SetPrezzo(double nuovoPrezzo)
        {
            if (nuovoPrezzo < 0)
            {
                return;
            }
            else
            {
                prezzo = nuovoPrezzo;
            }
        }
        public void SetIva(double nuovaIva)
        {
            if (nuovaIva < 0)
            {
                return;
            }
            else
            {
                iva = nuovaIva;
            }
        }
        public void SetDescrizione(string nuovaDescrizione)
        {
            descrizione = nuovaDescrizione;
        }
        public void SetNome(string nuovoNome)
        {
            nome = nuovoNome;
        }

        //------------------ METODI DELLA CLASSE PRODOTTO ---------------------
        // I metodi di cui vogliamo permettere l'eventuale OVERRIDE nelle sottoclassi, dobbiamo aggiungere la keyword virtual
        public virtual void NomeEsteso()
        {
            Console.WriteLine("Il codice esteso del prodotto è: " + codice + " - " + nome);
        }

        private protected string PadLeft()
        {
            string codiceString = codice.ToString();
            char zero = '0';
            return codiceString.PadLeft(8, zero);
        }
        public double PrezzoSenzaIva()
        {
            double totale;
            double percentualePrezzoSenzaIva;
            percentualePrezzoSenzaIva = (100 - iva);
            totale = prezzo * percentualePrezzoSenzaIva / 100;
            Console.WriteLine("Il prezzo senza iva di " + nome + " è: " + totale + " euro.");
            return totale;
        }
    }
}

