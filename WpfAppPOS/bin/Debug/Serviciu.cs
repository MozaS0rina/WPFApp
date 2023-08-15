using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    [Serializable]
    public class Serviciu : ProdusAbstract, IPackageble

    {
        public Serviciu() { } 

        public Serviciu(int Id, String Nume, String CodIntern, int Pret, string Categorie) : base (Id, Nume, CodIntern, Pret, Categorie)
        {
        }


        public override String Descriere()
        {
            return "Serviciul cu ID " + Id + " are " + Environment.NewLine + "numele: " + Nume + Environment.NewLine + "codul intern: [" + CodIntern + "] " + Environment.NewLine + "pretul: " + Pret + Environment.NewLine + "categoria: " + Categorie + Environment.NewLine;
        }

        public bool canAddToPackage(Pachet pachet)
        {
            int NrServicii = 0;
            foreach (ProdusAbstract item in pachet.elem_pachet)
            {
                if (item is Serviciu)
                    NrServicii++;
            }

            if (NrServicii < 1 && !isAdded)
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