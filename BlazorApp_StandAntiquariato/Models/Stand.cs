namespace BlazorApp_StandAntiquariato.Models
{
    public class Stand
    {
        public int IdStand { get; set; }
        public string? NomeAntiquario { get; set; }
        public string? CognomeAntiquario { get; set; }
        public char Zona { get; set; }
        public int Superficie { get; set; }
        public bool IsCoperto { get; set; }
        public DateTime DataInizio { get; set; }
    }
}
