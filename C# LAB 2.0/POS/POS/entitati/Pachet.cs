using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Pachet : ProdusAbstract
    {
        IEnumerable<int> elem_pachet = new List<int>();


        public string idPachet;
        public string numePachet;
        public string codInternPachet;

        public string IdPachet
        {
            get { return idPachet; }
            set { idPachet = value; }
        }

        public string NumePachet
        {
            get { return numePachet; }
            set { idPachet = value; }
        }

        public string CodInternPachet
        {
            get { return codInternPachet; }
            set { codInternPachet = value; }
        }

        public override string Descriere()
        {
            return "Pachet constituit din: " + elem_pachet.Count() + "elemente" ;
        }


        public Pachet(string unId, string unNume,string unCodIntern): base(unId, unNume, unCodIntern)
        {

        }
    }
}

