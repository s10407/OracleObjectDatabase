using System.Collections.Generic;

namespace OracleObjectDatabase.DAL
{
    public class Lekarz
    {
        public int IdLekarz { get; set; }
        public string Tytul { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Emaiil { get; set; }
        public string Telefon { get; set; }
        public virtual ICollection<Specjalizacja> Specjalizacje { get; set; }
        public virtual ICollection<Instytucja> Instytucje { get; set; }
    }
}