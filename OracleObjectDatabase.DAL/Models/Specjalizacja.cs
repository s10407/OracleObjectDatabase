using System.Collections.Generic;

namespace OracleObjectDatabase.DAL
{
    public class Specjalizacja
    {
        public int IdSpecjalizacja { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<Lekarz> Lekarze { get; set; }
    }
}