using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace entitati
{
    [Serializable]
    public class Serviciu : ProdusAbstract, IPackageble
    {
        private string codIntern; //cod intern
        private string id; //id
        private string nume; //nume


        public Serviciu()
        {

        }
        public Serviciu(string unCodIntern, string unId, string unNume) : base(unId, unNume, unCodIntern)
        /*constructor
        serviciu */

        {
            this.CodIntern = unCodIntern;
            this.Id = unId;
            this.Nume = unNume;
        }

       

        public string CodIntern //getter setter Cod Intern
        {
            get { return codIntern; }
            set { codIntern = value; }
        }

        

        public string Nume //getter setter nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Id //getter setter identificator
        {
            get { return id; }
            set { id = value; }
        }
        public string AfisareServiciu() //metoda pentru afisare serviciu
        {
            return $"Cod intern serviciu: {this.CodIntern} . \n ID serviciu: {this.Id} . \n Nume serviciu: {this.Nume}. ";

        }

        public bool canAddToPackage(Pachet pachet) //metoda interfetei IPackageble
        {
            return true;
        }

        public override String Descriere() //metoda derivata din clasa parinte ProdusAbstract, ea ANULEAZA metoda din ProdusAbstract
        {
            return $"ID {this.Id}: Nume: {this.Nume} . Cod intern: {this.CodIntern} .";

        }

       
    }
}