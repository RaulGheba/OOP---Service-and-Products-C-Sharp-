using System;
using System.Linq;
using entitati;
using System.Collections;

namespace app1
{
    class ServiciuMgr : ProduseAbstractMgr //clasa derivata din ProduseAbstractMgr
    {

        public void ReadServiciu() // Citeste UN serviciu, scris de user
        {
            Console.WriteLine("Introdu date serviciu: ");


            Console.WriteLine("Cod intern serviciu: ");

            string CodIntern = Console.ReadLine();

            Console.WriteLine("ID serviciu: ");

            string Id = Console.ReadLine();

            Console.WriteLine("Nume:");

            string Nume = Console.ReadLine();

            Serviciu serviciu = new Serviciu(CodIntern, Id, Nume);

            elemente.Append(serviciu);


        }


        public void ReadServicii(int nr, ArrayList servicii) // Citeste MAI MULTE servicii, scrise de user
        {
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("Introdu date serviciu " + (i + 1) + " : ");


                Console.WriteLine("Cod intern serviciu: ");

                string CodIntern = Console.ReadLine();

                Console.WriteLine("ID serviciu: ");

                string Id = Console.ReadLine();

                Console.WriteLine("Nume:");

                string Nume = Console.ReadLine();

                Serviciu serviciu = new Serviciu(CodIntern, Id, Nume);

                servicii.Add(serviciu);

            }

        }

        public void WriteServicii(ArrayList servicii)
        {
            Console.WriteLine("Informatii despre serviciile adaugate: ");

            foreach(Serviciu serviciu in servicii)
            {
                Console.WriteLine("Serviciu " + (servicii.IndexOf(serviciu) +  1) + " : ");
                Console.WriteLine("Cod intern: " + serviciu.CodIntern);
                Console.WriteLine("ID : " + serviciu.Id);
                Console.WriteLine("Nume: " + serviciu.Nume);
                Console.WriteLine();
                
            }
        }

      

    }
}
