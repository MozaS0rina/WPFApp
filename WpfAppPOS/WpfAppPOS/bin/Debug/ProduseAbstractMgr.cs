using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;

namespace app1
{
    abstract public class ProduseAbstractMgr
    {
        public List<Pachet> packages = new List<Pachet>();//lista pachetelor
        public int NrPachete = 0;

    }
}
