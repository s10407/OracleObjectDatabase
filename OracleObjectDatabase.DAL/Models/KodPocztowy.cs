namespace OracleObjectDatabase.DAL
{
    public class KodPocztowy
    {
        public int IdKodPocztowy { get; set; }
        public string Kod { get; set; }
        public int IdWojewodztwo { get; set; }
        public Wojewodztwo Wojewodztwo { get; set; }
    }
}