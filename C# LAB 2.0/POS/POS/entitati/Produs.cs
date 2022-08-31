using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace entitati
{
    [Serializable]
    public class Produs : ProdusAbstract, IPackageble
    {
        

        private string id; // identificator
        private String nume; //numele produsului
        private String codIntern; //codul Intern
        private String producator; //producator

        public Produs()
        {

        }

        public void save2XML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Produs));
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            xs.Serialize(sw, this);
            sw.Close();
        }


        public Produs(string unId, String unNume,
                        String unCodIntern,
                            String unProducator) : base(unId, unNume, unCodIntern)
        //constructor produs, derivat din ProdusAbstract
        {
            this.Id = unId;
            this.Nume = unNume;
            this.CodIntern = unCodIntern;
            this.Producator = unProducator;
        }

        public string Id //setter/getter pentru ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Nume  //setter/getter pentru nume
        {
            get { return nume; }
            set { nume = value; }
        }


        public string CodIntern //setter/getter pentru cod intern
        {
            get { return codIntern; }
            set
            {
                codIntern = value;
            }
        }

        public string Producator //setter/getter pentru producator
        {
            get { return producator; }
            set
            {
                producator = value;
            }
        }

        public string AfisareProdus() //metoda pentru afisare produs
        {

            return $"Producator produs : {this.Producator} . \n Nume: {this.Nume} . Cod intern: {this.CodIntern}";

        }

        public bool canAddToPackage(Pachet pachet)  //metoda interfetei IPackageble
        {
            return true;
        }

        public override string Descriere()//metoda derivata din clasa parinte ProdusAbstract,
                                          //ea ANULEAZA metoda din ProdusAbstract
        {
            return $"ID {this.Id}: Nume: {this.Nume} . Cod intern: {this.CodIntern} . Producator: {this.Producator}.";

        }



    }

}

