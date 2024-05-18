using AppJogoDaForca.Models;

namespace AppJogoDaForca.Repositories
{
    // guarda a lista de palavras 
    internal class WordRepositories
    {
        private List<Word> _words;
        public WordRepositories()
        {
            _words = new List<Word>();
            _words.Add(new Word("Nome", "Maria".ToUpper()));
            _words.Add(new Word("Profissão", "Engenheiro".ToUpper()));
            _words.Add(new Word("Profissão", "Pedreiro".ToUpper()));
            _words.Add(new Word("Profissão", "Cabeleireiro".ToUpper()));
            _words.Add(new Word("Profissão", "Policial".ToUpper()));
            _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
            _words.Add(new Word("Fruta", "Abacate".ToUpper()));
            _words.Add(new Word("Animal", "Gato".ToUpper()));
            _words.Add(new Word("País", "Brasil".ToUpper()));
            _words.Add(new Word("Cor", "Azul".ToUpper()));
            _words.Add(new Word("Profissão", "Medico".ToUpper()));
            _words.Add(new Word("Esporte", "Futebol".ToUpper()));
            _words.Add(new Word("Comida", "Pizza".ToUpper()));
            _words.Add(new Word("Instrumento Musical", "Violino".ToUpper()));
            _words.Add(new Word("Sobremesa", "Sorvete".ToUpper()));
            _words.Add(new Word("Filme", "Matrix".ToUpper()));
            _words.Add(new Word("Idioma", "Ingles".ToUpper()));
            _words.Add(new Word("Cidade", "Paris".ToUpper()));
            _words.Add(new Word("Personagem de Desenho", "Mickey".ToUpper()));
            _words.Add(new Word("Marca de Carro", "Toyota".ToUpper()));
            _words.Add(new Word("Planta", "Rosa".ToUpper()));
            _words.Add(new Word("Bebida", "Cafe".ToUpper()));
            _words.Add(new Word("Profissão", "Advogado".ToUpper()));
            _words.Add(new Word("Planeta", "Marte".ToUpper()));
            _words.Add(new Word("Animal", "Elefante".ToUpper()));
            _words.Add(new Word("País", "Japao".ToUpper()));
            _words.Add(new Word("Cor", "Verde".ToUpper()));
            _words.Add(new Word("Esporte", "Basquete".ToUpper()));
            _words.Add(new Word("Comida", "Hamburger".ToUpper()));
            _words.Add(new Word("Instrumento Musical", "Piano".ToUpper()));
            _words.Add(new Word("Sobremesa", "Brigadeiro".ToUpper()));
            _words.Add(new Word("Filme", "Titanic".ToUpper()));
            _words.Add(new Word("Idioma", "Espanhol".ToUpper()));
            _words.Add(new Word("Cidade", "Nova York".ToUpper()));
            _words.Add(new Word("Personagem de Desenho", "Bob Esponja".ToUpper()));
            _words.Add(new Word("Marca de Carro", "Ford".ToUpper()));
            _words.Add(new Word("Planta", "Girassol".ToUpper()));
            _words.Add(new Word("Bebida", "Refrigerante".ToUpper()));
            _words.Add(new Word("Planeta", "Saturno".ToUpper()));
            _words.Add(new Word("Profissão", "Professor".ToUpper()));
            _words.Add(new Word("Profissão", "Programador".ToUpper()));
            _words.Add(new Word("Profissão", "Arquiteto".ToUpper()));
            _words.Add(new Word("Profissão", "Designer".ToUpper()));
            _words.Add(new Word("Profissão", "Chef de cozinha".ToUpper()));
            _words.Add(new Word("Profissão", "Piloto".ToUpper()));
            _words.Add(new Word("Profissão", "Jornalista".ToUpper()));
            _words.Add(new Word("Profissão", "Bombeiro".ToUpper()));
            _words.Add(new Word("Profissão", "Fotógrafo".ToUpper()));
            _words.Add(new Word("Profissão", "Artista".ToUpper()));
            _words.Add(new Word("Hobby", "Pintura".ToUpper()));
            _words.Add(new Word("Hobby", "Danca".ToUpper()));
            _words.Add(new Word("Hobby", "Caminhada".ToUpper()));
            _words.Add(new Word("Hobby", "Fotografia".ToUpper()));
            _words.Add(new Word("Hobby", "Leitura".ToUpper()));
            _words.Add(new Word("Hobby", "Cozinhar".ToUpper()));
            _words.Add(new Word("Hobby", "Jardinagem".ToUpper()));
            _words.Add(new Word("Hobby", "Musica".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Bicicleta".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Aviao".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Navio".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Caminhao".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Helicoptero".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Trem".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Onibus".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Carro".ToUpper()));
            _words.Add(new Word("Ferramenta", "Martelo".ToUpper()));
            _words.Add(new Word("Ferramenta", "Chave de fenda".ToUpper()));
            _words.Add(new Word("Ferramenta", "Serra".ToUpper()));
            _words.Add(new Word("Ferramenta", "Alicate".ToUpper()));
            _words.Add(new Word("Ferramenta", "Broca".ToUpper()));
            _words.Add(new Word("Ferramenta", "Lixa".ToUpper()));
            _words.Add(new Word("Ferramenta", "Serrote".ToUpper()));
            _words.Add(new Word("Ferramenta", "Trena".ToUpper()));
            _words.Add(new Word("Hobby", "Viagem".ToUpper()));
            _words.Add(new Word("Hobby", "Surfe".ToUpper()));
            _words.Add(new Word("Hobby", "Artesanato".ToUpper()));
            _words.Add(new Word("Hobby", "Yoga".ToUpper()));
            _words.Add(new Word("Hobby", "Ciclismo".ToUpper()));
            _words.Add(new Word("Hobby", "Escalada".ToUpper()));
            _words.Add(new Word("Hobby", "Pesca".ToUpper()));
            _words.Add(new Word("Hobby", "Escrita".ToUpper()));
            _words.Add(new Word("Hobby", "Costura".ToUpper()));
            _words.Add(new Word("Hobby", "Jogos de Tabuleiro".ToUpper()));
            _words.Add(new Word("Hobby", "Jogos de Cartas".ToUpper()));
            _words.Add(new Word("Hobby", "Programação".ToUpper()));
            _words.Add(new Word("Hobby", "Teatro".ToUpper()));
            _words.Add(new Word("Hobby", "Desenho".ToUpper()));
            _words.Add(new Word("Hobby", "Fotografia".ToUpper()));
            _words.Add(new Word("Hobby", "Meditar".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Moto".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Barco".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Canoa".ToUpper()));
            _words.Add(new Word("Meio de Transporte", "Jet ski".ToUpper()));
            _words.Add(new Word("Ferramenta", "Tesoura".ToUpper()));
            _words.Add(new Word("Ferramenta", "Furadeira".ToUpper()));
            _words.Add(new Word("Ferramenta", "Plaina".ToUpper()));
            _words.Add(new Word("Ferramenta", "Chave inglesa".ToUpper()));
            _words.Add(new Word("Ferramenta", "Marreta".ToUpper()));
            _words.Add(new Word("Ferramenta", "Trena a laser".ToUpper()));
            _words.Add(new Word("Cor", "Cinza".ToUpper()));
            _words.Add(new Word("Acessório", "Pulseira".ToUpper()));
            _words.Add(new Word("Acessório", "Relogio".ToUpper()));
        }

        public Word GetRandomWord()
        {
            Random rand = new Random(); 
            var number = rand.Next(0, _words.Count);
            return _words[number];
        }
    }
}
