namespace İşkurExxel.Model
{
    public class IstekModel
    {
        public string Tip { get; set; }        // Lavabo/Sınıf
        public string LavaboNo { get; set; }   // Tip = Lavabo ise zorunlu
        public string Kat { get; set; }
        public string Sorun { get; set; }
        public string ImagePath { get; set; }  // Fotoğraf yolu
    }
}