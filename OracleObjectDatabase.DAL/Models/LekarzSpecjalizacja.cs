using System;

namespace OracleObjectDatabase.DAL
{
    public class LekarzSpecjalizacja
    {
        public int IdLekarz { get; set; }
        public Lekarz Lekarz { get; set; }
        public int IdSpecjalizacja { get; set; }
        public Specjalizacja Specjalizacja { get; set; }
        public DateTime? DataZdobycia { get; set; }
    }
}