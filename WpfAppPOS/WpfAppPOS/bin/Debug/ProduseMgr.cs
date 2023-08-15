using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using entitati;


namespace app1
{
    public class ProduseMgr : ProduseAbstractMgr
    {
        public List<Produs> InitListafromXML()
        {
           List<Produs> elem = new List<Produs>();//lista produse
            int NrElemente = 0;

            XmlDocument doc = new XmlDocument(); //initializam lista dintr-un fisier XML
            doc.Load("Produse.xml");//incarcam fisierul       
            XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs"); //selectam nodurile
            foreach (XmlNode nod in lista_noduri)
            {
                //itereaza si selecteaza cimpurile fiecarui nod si
                //informatia continuta in cadrul proprietatii InnerText
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                string producator = nod["Producator"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                //adaugam in lista produse
                elem.Add(new Produs(NrElemente + 1, nume, codIntern, producator, pret, categorie));
                NrElemente++;
            }
            return elem;
        }
    }
}