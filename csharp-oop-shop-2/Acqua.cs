using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdottiEstesi
    
{
    
    internal class Acqua : Prodotto
    {
        private double ph;
        private string sorgente;
        private double litriNellaBottiglia;
        public static double GALLONI = 3.785;
        public static double MAX_LITRI = 1.5;








        public Acqua(string nome, string descrizione, double ph, string sorgente,int iva, double prezzo) : base(nome, descrizione, prezzo, iva)
        {
            
            this.ph = ph;   
            this.sorgente = sorgente; 
            this.litriNellaBottiglia = MAX_LITRI;
            


        }

        public double getLitri()
        {
            return litriNellaBottiglia;
        }


        public void Bevi(double litriDaBere)
        {
            if ( litriDaBere <= litriNellaBottiglia)
            {
                litriNellaBottiglia = litriNellaBottiglia - litriDaBere;
                Console.WriteLine("glu glu glu, ho bevuto " + litriDaBere + " litri");
            }
            else
            {
                Console.WriteLine("glu glu glu, mi dispiace hai finito la bottiglia");
                litriNellaBottiglia = 0;
            }
        }


        public void Riempi(double LitriDaRiempire)
        {
            double totaleLitri = litriNellaBottiglia + LitriDaRiempire;
           
            if (totaleLitri > MAX_LITRI )
            {
                Console.WriteLine("Mi dispiace i litri che vuoi aggiungere superano i litri della bottiglia");

            }
            else
            {
                litriNellaBottiglia = totaleLitri;
            }

        }
        public void svuota()
        {
            litriNellaBottiglia = 0;
        }
        public override void NomeEsteso()
        {
            // CODICE - NOME - LITRI
            Console.WriteLine("Il nome esteso della bevanda è: " + base.PadLeft() + " - " + this.nome + " - " + litriNellaBottiglia + " litri" + " - " + this.ph + "ph" + " - " + this.sorgente);
        }
        public static double convertiInGalloni(double litri)
        {
            double litriInGalloni;
            litriInGalloni = GALLONI * litri;
            return litriInGalloni;
        }

    }
}
