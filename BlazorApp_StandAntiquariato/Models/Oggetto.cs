namespace BlazorApp_StandAntiquariato.Models
{
    public class Oggetto
    {
        public int IdOggetto { get; set; }
        public string? Tipo { get; set; }
        public string? MaterialePrincipale { get; set; }
        public string? Epoca { get; set; }
        public decimal PrezzoEsposto { get; set; }
        public int StandId { get; set; }
        public string? PercorsoImmagine { get; set; }
    }
}
