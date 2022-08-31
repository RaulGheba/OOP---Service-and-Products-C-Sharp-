using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using entitati;
using System.Collections;

namespace app1
{
    class ProduseMgr : ProduseAbstractMgr
    {


        private int nrProduse = 1;

        public void ReadProdus()
        {

            for (int i = 0; i < nrProduse; i++) // citim produsul, unul singur
            {


                Console.WriteLine("Introdu un produs");
                Console.WriteLine("ID:");
                string id = Console.ReadLine();
                Console.Write("Numele:"); //user-ul atribuie nume prod.
                string nume = Console.ReadLine();
                Console.Write("Codul intern:"); //user-ul atribuie cod intern prod.
                string codIntern = Console.ReadLine();
                Console.Write("Producator:"); //user-ul atribuie producator prod.
                string producator = Console.ReadLine();

                Produs produs = new Produs(id, nume,
                codIntern, producator); /*produsul este creat de catre
                                         constructor folosind datele user-ului */

                elemente.Append(produs); // produsul "scris" de user este stocat in lista
                
            }

            
        }
        public void ReadProduse(int nr, ArrayList produse) // citim produsele, mai multe
        {
            
            for (int i = 0; i < nr; i++)
            {
               Console.WriteLine(" Produs " + (i + 1) + " : ");
                Console.WriteLine("ID :");
                string id = Console.ReadLine();

                Console.WriteLine("Nume :");
                string Nume = Console.ReadLine();

                Console.WriteLine("Cod intern: ");
                string CodIntern = Console.ReadLine();

                Console.WriteLine("Producator: ");
                string Producator = Console.ReadLine();
                Produs produs = new Produs(id, Nume, CodIntern, Producator);

                produse.Add(produs);

            }
        }


        public void WriteProduse(ArrayList produse)
        {
            Console.WriteLine("Informatii produse adaugate: ");
            foreach (Produs prod in produse)
            {
                Console.WriteLine("Produs " + (produse.IndexOf(prod) + 1) + " : ");
                Console.WriteLine(" ID : " + prod.Id);
                Console.WriteLine(" Nume : " + prod.Nume);
                Console.WriteLine(" Cod intern : " + prod.CodIntern);
                Console.WriteLine(" Producator : " + prod.Producator);

            }
        }
       


    }
}
