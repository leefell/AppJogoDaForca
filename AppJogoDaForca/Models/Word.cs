namespace AppJogoDaForca.Models
{
    public class Word
    {
        public Word(String tips, String text)
        {
            this.Tips = tips;
            this.Text = text;
        }
        public String Tips { get; set; } = string.Empty;
        public String Text { get; set; } = string.Empty;
    }
}
