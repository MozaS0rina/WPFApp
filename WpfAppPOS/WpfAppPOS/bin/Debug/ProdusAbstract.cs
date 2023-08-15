using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace entitati
{
    // Pentru a putea fi serializate binar obiectele trebuie să adăugăm atributul (serializare implicitǎ): 
    [Serializable]
    public abstract class ProdusAbstract 
    {
        private int id;// identificator
        private String nume;// numele produsului
        private String codIntern;// codul Intern
        private int pret;//pret
        private String categorie;//categorie
        [XmlIgnore]
        public bool isAdded = false;

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }
        public int Pret { get => pret; set => pret = value; }
        public string Categorie { get => categorie; set => categorie = value; }

        public ProdusAbstract() { } //Creăm un constructor fără parametri pentru a putea face serializarea și deserializarea

        public ProdusAbstract(int Id, String Nume, String CodIntern, int Pret, string Categorie) {
            this.Id = Id;
            this.Nume = Nume;
            this.CodIntern = CodIntern;
            this.pret = Pret;
            this.categorie = Categorie;
        }

        public abstract String Descriere();
    }
}
