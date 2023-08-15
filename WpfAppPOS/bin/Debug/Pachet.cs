using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    [Serializable]
    public class Pachet : ProdusAbstract
    {
        public List<ProdusAbstract> elem_pachet = new List<ProdusAbstract>();

        public void Add(ProdusAbstract item)
        {
            elem_pachet.Add(item);
        }

        public Pachet() {}

        public Pachet(int Id, String Nume, String CodIntern, int Pret, string Categorie) : base(Id, Nume, CodIntern, Pret, Categorie)
        {
        }

        public override string Descriere()
        {
            return "Pachetul cu ID " + Id + " are " + Environment.NewLine + "numele: " + Nume + Environment.NewLine + "codul intern: [" + CodIntern + "] " + Environment.NewLine + "pretul: " + Pret + Environment.NewLine + "categoria: " + Categorie + Environment.NewLine + Environment.NewLine +  "***Acest pachet contine urmatoarele***";
        }

        public void AltaDescriere()
        {
            Console.WriteLine("Continutul pachetului " + this.Id + " este format din:");
            
            foreach (ProdusAbstract item in elem_pachet)
                    Console.WriteLine(item.Descriere());
        } 
    }
}
