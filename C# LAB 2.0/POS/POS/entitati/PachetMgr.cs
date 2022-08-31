using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace entitati
{

    public class PachetMgr
    {
        
        public void ReadPachet(int p, int s, object[] mockup)
        {


            for (int i = 0; i <= p; i++)
            {
                Console.WriteLine($"Produs {i + 1} :");

                Console.WriteLine("ID :");
                string id = Console.ReadLine();
                Console.WriteLine("Nume: ");
                string nume = Console.ReadLine();
                Console.WriteLine("Cod intern :");
                string codIntern = Console.ReadLine();
                Console.WriteLine("Producator :");
                string producator = Console.ReadLine();

                Produs produs = new Produs(id, nume, codIntern, producator);
                mockup[i] = produs;




                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine($"Serviciu {j + 1} :");

                    Console.WriteLine("ID :");
                    string idS = Console.ReadLine();
                    Console.WriteLine("Nume: ");
                    string numeS = Console.ReadLine();
                    Console.WriteLine("Cod intern :");
                    string codInternS = Console.ReadLine();


                    Serviciu serviciu = new Serviciu(codIntern, id, nume);

                    mockup[j] = serviciu;


                }
            }
        }



    }
           
}

    

    
