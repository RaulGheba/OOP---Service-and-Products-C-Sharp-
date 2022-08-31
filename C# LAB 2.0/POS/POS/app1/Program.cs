using System;
using System.Collections.Generic;
using System.Text;
using entitati;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace app1
{
    class Program
    {



        static void Main(string[] args)
        {

            XmlSerializer serializerS = new XmlSerializer(typeof(Serviciu));
            XmlSerializer serializerP = new XmlSerializer(typeof(Produs));

            IEnumerable<object> elemente = new List<object>() { };

            Produs produs1 = new Produs("1", "Mouse", "1111", "USA");
            Produs produs2 = new Produs("2", "Tastatura", "2222", "RO");
            Produs produs3 = new Produs("3", "Casti Wireless", "3333", "JP");

            elemente = elemente.Append(produs1);
            elemente = elemente.Append(produs2);
            elemente = elemente.Append(produs3);

            Console.WriteLine("Produse deja existente: \n");


            foreach (Produs prod in elemente)
            {
                Console.WriteLine("ID: ");
                Console.WriteLine(prod.Id);

                Console.WriteLine("Nume: ");
                Console.WriteLine(prod.Nume);

                Console.WriteLine("Cod intern: ");
                Console.WriteLine(prod.CodIntern);

                Console.WriteLine("Producator: ");
                Console.WriteLine(prod.Producator + "\n");

            }


            ArrayList produse = new ArrayList();
            ArrayList servicii = new ArrayList();



            Console.WriteLine("Cate produse doresti sa adaugi? "); //user-ul ne spune
                                                                   //cate produse doreste
            int nrProduse = Convert.ToInt32(Console.ReadLine());

            //I. GESTIONARE PRODUSE

            ProduseMgr mgrProduse = new ProduseMgr(); //manager de produse din clasa ProduseMgr

            if (nrProduse == 1) //daca userul solicita UN produs, el este serializat
            {
                //id
                Console.WriteLine("Id: ");

                string id = Console.ReadLine();


                //nume
                Console.WriteLine("Nume: ");

                string nume = Console.ReadLine();


                //cod intern
                Console.WriteLine("Cod intern :");

                string codIntern = Console.ReadLine();


                //producator
                Console.WriteLine("Producator :");

                string producator = Console.ReadLine();


                Produs produs = new Produs(id, nume, codIntern, producator);

                produse.Add(produs); //adaugam produsul in lista de produse

                string filePath = @"C:\\Projects\\POS\\POS\\Produse.xml";
                FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                serializerP.Serialize(fileStream, produs);

                Console.WriteLine("Produs stocat in Produse.xml!");
            }



            else if (nrProduse > 1) // daca acesta solicita MAI MULTE
            {
                mgrProduse.ReadProduse(nrProduse, produse);
                Console.WriteLine("Produse stocate!");
            }
          
            mgrProduse.WriteProduse(produse); //afisam produsele
            Console.WriteLine();

            // II. Gestionare servicii

            ServiciuMgr mgrServicii = new ServiciuMgr(); // manager de servicii din clasa
            // ServiciuMgr

            Console.WriteLine("Cate servicii doresti sa adaugi? "); //user-ul ne spune cate servicii doreste
            int nrServicii = Convert.ToInt32(Console.ReadLine());



            if (nrServicii == 1) //daca userul solicita UN serviciu, el este serializat
            {
                //id
                Console.WriteLine("Id serviciu: ");

                string id = Console.ReadLine();


                //nume
                Console.WriteLine("Nume: ");

                string nume = Console.ReadLine();


                //cod intern
                Console.WriteLine("Cod intern :");

                string codIntern = Console.ReadLine();

                Serviciu serviciu = new Serviciu(codIntern, id, nume);

                servicii.Add(serviciu); //adaugam serviciul in lista de servicii ArrayList


                string filePath = @"c:\\Projects\\POS\\POS\\Servicii.xml";
                FileStream fileStream2 = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                serializerS.Serialize(fileStream2, serviciu);

                Console.WriteLine("Serviciu stocat in Servicii.xml! \n" );
            }

            else if (nrServicii > 1) //daca userul solicita MAI MULTE servicii
            {
                mgrServicii.ReadServicii(nrServicii, servicii);
                Console.WriteLine();
                Console.WriteLine("Servicii stocate! ");
                Console.WriteLine();
                   
            }

     
            mgrServicii.WriteServicii(servicii);

            Console.WriteLine("Doriti crearea unui pachet? ");
            string answer = Console.ReadLine();

            if (answer == "d")
            {
                
                PachetMgr mgrPachet = new PachetMgr();
                int p;
                int s;
                Console.WriteLine("Nr. produse: ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nr. servicii: ");
                s = Convert.ToInt32(Console.ReadLine());
                object[] pachet = new object[p+s];
                mgrPachet.ReadPachet(p,s, pachet);
            }

            Console.ReadLine();
        }

   
        } //FINALUL METODEI MAIN 




    }




