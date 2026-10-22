

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

        public Fahrzeug(string kennzeichen, Fahrzeugtyp fahrzeugtyp)
        {
            this.kennzeichen = kennzeichen;
            this.fahrzeugtyp = fahrzeugtyp;
        }
    }
    

}
