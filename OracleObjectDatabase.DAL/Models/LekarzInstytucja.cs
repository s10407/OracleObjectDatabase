namespace OracleObjectDatabase.DAL
{
    public class LekarzInstytucja
    {
        public int IdLekarz { get; set; }
        public int IdInstytucja { get; set; }
        public Lekarz Lekarz { get; set; }
        public Instytucja Instytucja { get; set; }
        public string Stanowisko { get; set; }
    }
}