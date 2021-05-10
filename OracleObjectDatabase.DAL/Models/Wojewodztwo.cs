namespace OracleObjectDatabase.DAL
{
    public class Wojewodztwo
    {
        public int IdWojewodztwo { get; set; }
        public string Nazwa { get; set; }
        public int IdPrzedstawiciel { get; set; }
        public Przedstawiciel Przedstawiciel { get; set; }
    }
}