

namespace Fahrzeugcheck_Anwendung.Models
{
    public class Fahrzeug
    {
        private string kennzeichen;
        private Fahrzeugtyp fahrzeugtyp;

        private DateTime hauptuntersuchungstermin;

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

        public DateTime Hauptuntersuchungstermin
        {
            get { return hauptuntersuchungstermin; }
            set { hauptuntersuchungstermin = value; }
        }

        public Fahrzeug(string kennzeichen, Fahrzeugtyp fahrzeugtyp, DateTime hauptuntersuchungstermin)
        {
            this.kennzeichen = kennzeichen;
            this.fahrzeugtyp = fahrzeugtyp;
            this.hauptuntersuchungstermin = hauptuntersuchungstermin;
        }
    }
    

}
