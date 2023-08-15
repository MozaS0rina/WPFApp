using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    [Serializable]
    public class Produs : ProdusAbstract, IPackageble
    {
        
        private String producator;// producator

        public string Producator { get => producator; set => producator = value; }

        public Produs() {}

        public Produs(int Id, String Nume, String CodIntern, String producator, int Pret, string Categorie) : base (Id, Nume, CodIntern, Pret, Categorie)
        {
            this.Producator = producator;
        }

        public override String Descriere()
        {
            return "Produsul cu ID " + Id + " are " + Environment.NewLine + "numele: " + Nume + Environment.NewLine + "cod intern: [" + CodIntern + "]" + Environment.NewLine +  "producator: " + Producator + Environment.NewLine + "pretul: " + Pret + Environment.NewLine + "categoria: " + Categorie + Environment.NewLine;
        }

        public bool canAddToPackage(Pachet pachet)
        {
            int NrProduse = 0;
            foreach(ProdusAbstract  item in pachet.elem_pachet){
                if (item is Produs)
                    NrProduse++;
            }

            if (NrProduse < 2 && !isAdded)
            {
                this.isAdded = true;
                return true;
            }
            else
                return
                    false;
        }
    }
}
