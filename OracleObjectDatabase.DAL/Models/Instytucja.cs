using System.Collections.Generic;

namespace OracleObjectDatabase.DAL
{
    public class Instytucja
    {
        public int IdInstytucja { get; set; }
        public string NazwaPelna { get; set; }
        public string NazwaKrotka { get; set; }
        public string Adres { get; set; }
        public int IdTypInstytucji { get; set; }
        public TypInstytucji TypInstytucji { get; set; }
        public int IdKodpocztowy { get; set; }
        public KodPocztowy KodPocztowy { get; set; }
        public virtual ICollection<Lekarz> Lekarze { get; set; }
    }
}