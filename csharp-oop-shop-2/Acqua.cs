using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProdottiEstesi
    
{
    
    internal class Acqua : Prodotto
    {
        private double ph;
        private string sorgente;
        private double litriNellaBottiglia;
        public readonly static double GALLONI = 3.785;
        public readonly static double MAX_LITRI = 1.5;
        private double litri;








        public Acqua(string nome, string descrizione, double ph, double litri, string sorgente,int iva, double prezzo) : base(nome, descrizione, prezzo, iva)
        {


            if(litri > MAX_LITRI)
            {
                Console.WriteLine("Litri massimi per ogni bottiglia 1.5L");
                Environment.Exit(1);
            }

            this.litri = litri;
            this.ph = ph;   
            this.sorgente = sorgente; 
            this.litriNellaBottiglia = this.litri;
            


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
           
            if (totaleLitri > this.litri || LitriDaRiempire < 0 )
            {
                Console.WriteLine("Mi dispiace i litri che vuoi aggiungere superano i litri della bottiglia o hai messo un numero minore di zero");
                

            }
            else
            {
                litriNellaBottiglia = totaleLitri;
                Console.WriteLine("Ho riempito la bottiglia di: " + litriNellaBottiglia + " litri");

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
