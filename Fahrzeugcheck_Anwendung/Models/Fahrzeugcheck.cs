
namespace Fahrzeugcheck_Anwendung.Models
{
    public class Fahrzeugcheck
    {
        private Fahrzeug fahrzeug;
        private string pruefer; 
        private Guid id;
        private DateTime zeitpunkt;
        private string bemerkung;
        private List<Pruefpunkt> pruefpunkte;

        public Fahrzeug Fahrzeug
        {
            get { return fahrzeug; }
            set { fahrzeug = value; }
        }
        public string Pruefer
        {
            get { return pruefer; }
            set { pruefer = value; }
        }
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Zeitpunkt
        {
            get { return zeitpunkt; }
            set { zeitpunkt = value; }
        }
        public string Bemerkung
        {
            get { return bemerkung; }
            set { bemerkung = value; }
        }
        public List<Pruefpunkt> Pruefpunkte
        {
            get { return pruefpunkte; }
            set { pruefpunkte = value; }
        }
        public Fahrzeugcheck(Fahrzeug fahrzeug, string pruefer)
        {
            this.fahrzeug = fahrzeug;
            this.pruefer = pruefer;
            this.id = Guid.NewGuid();
            this.zeitpunkt = DateTime.Now;
            this.bemerkung = string.Empty;
            this.pruefpunkte = new List<Pruefpunkt>();

        }

        public int ZaehleOffenePruefpunkte()
        {
            int zaehler = 0;

            foreach (Pruefpunkt pruefpunkt in this.pruefpunkte)
            {
                if (pruefpunkt.Zustand == Zustand.Ungeprueft)
                {
                    zaehler++;
                }
            }

            return zaehler;
        }
        
        public int ZaehleMaengel()
        {
            int zaehler = 0;

            foreach (Pruefpunkt pruefpunkt in this.pruefpunkte)
            {
                if (pruefpunkt.Zustand == Zustand.Mangel)
                {
                    zaehler++;
                }
            }

            return zaehler;
        }

    }
}
