using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using entitati;

namespace app1
{
    public class ServiciuMgr : ProduseAbstractMgr
    {
        public List<Serviciu> InitListafromXML()
        {
            List<Serviciu> elem = new List<Serviciu>();//lista servicii
            int NrElemente = 0;

            XmlDocument doc = new XmlDocument(); //initializam lista dintr-un fisier XML
            doc.Load("Servicii.xml");//incarcam fisierul       
            XmlNodeList lista_noduri = doc.SelectNodes("/servicii/Serviciu"); //selectam nodurile
            foreach (XmlNode nod in lista_noduri)
            {
                //itereaza si selecteaza cimpurile fiecarui nod si
                //informatia continuta in cadrul proprietatii InnerText
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                //adauga in lista produse
                elem.Add(new Serviciu(NrElemente + 1, nume, codIntern, pret, categorie));
                NrElemente++;
            }
            return elem;
        }
    }
}