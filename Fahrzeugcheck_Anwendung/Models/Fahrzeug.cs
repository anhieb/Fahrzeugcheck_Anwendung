using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugcheck_Anwendung.Models
{
    public class Fahrzeug
    {
        private string kennzeichen;
        private Fahrzeugtyp fahrzeugtyp;

        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }

        public Fahrzeugtyp Fahrzeugtyp
        {
            get { return fahrzeugtyp; }
            set { fahrzeugtyp = value; }
        }
    }
    

}
