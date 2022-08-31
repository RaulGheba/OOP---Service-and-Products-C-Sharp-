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
    public abstract class ProdusAbstract

    {
        private string id; // identificator
        private String nume; //numele produsului
        private String codIntern; //codul Intern
        private String producator; //producatorul produsului


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

        public ProdusAbstract()
        {

        }

        public ProdusAbstract(String unId, String unNume,
         String unCodIntern) // constructor ProdusAbstract
        {
            this.Id = unId;
            this.Nume = unNume;
            this.CodIntern = unCodIntern;
        }

        public abstract string Descriere(); // metoda abstracta, care va fi implementata 
                                            // in clasele copii Produs si Serviciu

        public void save2XML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ProdusAbstract));
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            xs.Serialize(sw, this);
            sw.Close();
        }

    }
}
