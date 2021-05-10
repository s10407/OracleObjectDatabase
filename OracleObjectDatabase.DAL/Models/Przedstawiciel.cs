using System;
using System.Collections.Generic;

namespace OracleObjectDatabase.DAL
{
    public class Przedstawiciel
    {
        public int IdPrzedstawiciel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime? DataZatrudnienia { get; set; }
        public virtual ICollection<Wojewodztwo> Wojewodztwa { get; set; }
    }
}