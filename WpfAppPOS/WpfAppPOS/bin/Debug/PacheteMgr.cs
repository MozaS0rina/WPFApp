using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;
//Adăugăm namespace-urile necesare pentru serializare
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace app1
{
    public class PacheteMgr : ProduseAbstractMgr
    {
        public void InitListafromXML()
        {
            XmlDocument doc = new XmlDocument(); //initializam lista dintr-un fisier XML
            doc.Load("Pachete.xml");//incarcam fisierul       
            XmlNodeList lista_noduri = doc.SelectNodes("/pachete/Pachet"); //selectam nodurile
            foreach (XmlNode nod in lista_noduri)
            {
                //itereaza si selecteaza cimpurile fiecarui nod si
                //informatia continuta in cadrul proprietatii InnerText
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                //adauga in lista pachetele
                packages.Add(new Pachet(NrPachete + 1, nume, codIntern, pret, categorie));
                NrPachete++;
            }
        }

        public void ReadPachet()
        {
            InitListafromXML();
            ProduseMgr Produse = new ProduseMgr();
            ServiciuMgr Servicii = new ServiciuMgr();

            List<Produs> prod = Produse.InitListafromXML();//lista produse
            List<Serviciu> serv= Servicii.InitListafromXML();//lista servicii

            foreach (Pachet pachet in packages){ 
                foreach (Produs item in prod){
                    if (item.canAddToPackage(pachet)){//verificari
                    pachet.Add(item);//adaugare
                    }
                }

            foreach (Serviciu item in serv){
                if (item.canAddToPackage(pachet)){
                        pachet.Add(item);
                    }
                }
            }
        }

        //Adăugăm metoda pentru serializarea XML 
        public void save2XML(string fileName)
        {
            //urmează serializarea unui tablou de elemente:
            Type[] prodAbstractTypes = new Type[3];
            prodAbstractTypes[0] = typeof(Serviciu); //de tip serviciu
            prodAbstractTypes[1] = typeof(Produs); //de tip produs
            prodAbstractTypes[2] = typeof(Pachet); //de tip pachet
            //XmlSerializer este clasa care se ocupă de serializarea şi deserializarea obiectelor
            //Constructorul folosit primeşte un parametrul de tip Pachet 
            XmlSerializer xs = new XmlSerializer(typeof(List<Pachet>), prodAbstractTypes);
            //StreamWrite este clasa care realizează scrierea datelor
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            xs.Serialize(sw, this.packages);
            sw.Close();
        }

        //Adăugăm metoda pentru deserializarea XML 
        public static List<Pachet> loadFromXML(string fileName)
        {
            Type[] prodAbstractTypes = new Type[3];
            prodAbstractTypes[0] = typeof(Serviciu);
            prodAbstractTypes[1] = typeof(Produs);
            prodAbstractTypes[2] = typeof(Pachet);
            XmlSerializer xs = new XmlSerializer(typeof(List<Pachet>), prodAbstractTypes);
            //FileStream este clasa care deschide și închide fișierele dintr-un sistem de fișiere
            FileStream fs = new FileStream(fileName + ".xml", FileMode.Open);
            //XmlReader oferă acces la citirea datelor dintr-un fișier XML
            XmlReader reader = new XmlTextReader(fs);
            List<Pachet> ListaElem = (List<Pachet>)xs.Deserialize(reader);
            fs.Close();
            return ListaElem;
        }

 
      
       
    }
}