

namespace Fahrzeugcheck_Anwendung.Models
{
    public class Pruefpunkt
    {
        private string namePruefpunkt;
        private Zustand zustand;

        public string NamePruefpunkt
        {
            get { return namePruefpunkt; }
            set { namePruefpunkt = value; }
        }

        public Zustand Zustand
        {
            get { return zustand; }
            set { zustand = value; }
        }

        public Pruefpunkt(string namePruefpunkt, Zustand zustand)
        {
            this.namePruefpunkt = namePruefpunkt;
            this.zustand = zustand;
        }
    }

    public enum Zustand
    {
        Ungeprueft,
        Mangel,
        OK
    }
}
    
