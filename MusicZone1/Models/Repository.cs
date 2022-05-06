namespace MusicZone1.Models
{
    public static class Repository
    {
        private static List<Banda> bandas = new List<Banda>();
        public static List<Banda> Bandas { get { return bandas; } } 
    }
}
