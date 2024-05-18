using AppJogoDaForca.Models;
using AppJogoDaForca.Repositories;
using AppJogoDaForca.Libraries.Text;
using System.Text;

namespace AppJogoDaForca
{
    public partial class MainPage : ContentPage
    {
        private Word _word;
        private int _errors = 0;
        private Style _successStyle; // Armazena o estilo de sucesso para reutilização

        public MainPage()
        {
            InitializeComponent();
            _successStyle = (Style)App.Current.Resources.MergedDictionaries.ElementAt(1)["Sucess"]; // Recupera o estilo de sucesso uma vez
            ResetScreen();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.IsEnabled = false; // o usuário não pode clicar na mesma letra novamente

            string letter = button.Text; // armazena a letra que foi clicada

            var positions = _word.Text.GetPositions(letter);

            if (positions.Count == 0)
            {
                ErrorHandler(button);
                await CheckGameOver();
            }
            else
            {
                ReplaceLetter(letter, positions);
                button.Style = _successStyle; // Aplica o estilo de sucesso
                await CheckWinner(); // Verifica se o jogador ganhou
            }
        }

        #region Handlers
        private void ReplaceLetter(string letter, List<int> positions)
        {
            foreach (int position in positions)
            {
                LblText.Text = LblText.Text.Remove(position, 1).Insert(position, letter);
            }
        }

        private void ErrorHandler(Button button)
        {
            _errors++;
            ImgMain.Source = ImageSource.FromFile($"forca{_errors + 1}.png"); // Troca a imagem conforme o usuário erra
            button.Style = (Style)App.Current.Resources.MergedDictionaries.ElementAt(1)["Failure"]; // Aplica o estilo de falha
        }

        #endregion

        #region VerifyConditions
        private async Task CheckWinner()
        {
            if (!LblText.Text.Contains("_") && _errors < 6) // Verifica se todas as letras foram adivinhadas e se o jogador não perdeu ainda
            {
                bool continuePlaying = await DisplayAlert("Parabéns!", "Você venceu!", "Novo Jogo", "Sair");
                if (continuePlaying)
                    ResetScreen();
                else
                    App.Current.Quit();
            }
        }

        private async Task CheckGameOver()
        {
            if (_errors == 6) // Verifica se o jogador perdeu
            {
                bool continuePlaying = await DisplayAlert("Fim de Jogo!", $"Você perdeu! A resposta era: {_word.Text}", "Novo Jogo", "Sair");
                if (continuePlaying)
                    ResetScreen();
                else
                    App.Current.Quit();
            }
        }

        #endregion

        #region ResetScreen - Revert screen to initial state
        private void ResetScreen()
        {
            ResetVirtualKeyBoard();
            ResetErrors();
            SortNewWord();
        }

        private void SortNewWord()
        {
            var repository = new WordRepositories();
            _word = repository.GetRandomWord();

            LblTips.Text = _word.Tips;
            // LblText.Text = new string('_', _word.Text.Length); // velho

            StringBuilder hiddenWord = new StringBuilder(); // logica de underscore refatorada para nao colocar underline em espaços da palavra
            foreach(char c in _word.Text)
            {
                if (char.IsLetter(c))
                    hiddenWord.Append('_');
                else
                    hiddenWord.Append(c);
            }
            LblText.Text = hiddenWord.ToString();
        }

        private void ResetErrors()
        {
            _errors = 0;
            ImgMain.Source = ImageSource.FromFile("forca1.png"); // Reinicia a imagem
        }

        private void ResetVirtualKeyBoard()
        {
            foreach (var child in KeyboardContainer.Children)
            {
                if (child is HorizontalStackLayout horizontal)
                {
                    foreach (Button button in horizontal.Children) // Reseta todos os botões do teclado
                    {
                        button.IsEnabled = true;
                        button.Style = null;
                    }
                }
            }
        }

        private void OnButtonClickedResetGame(object sender, EventArgs e)
        {
            ResetScreen();
        }

        #endregion
    }
}
