using System;
using Modelos;
using Microsoft.Maui.Controls;


namespace appEquipe
{
    public partial class CadastroFornecedor : ContentPage
    {

        public Fornecedor fornecedor { get; set; }

        Controle.ControleFornecedor controleFornecedor = new Controle.ControleFornecedor();
        
        
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void VoltarMenu (object sender, EventArgs args)
        {
            if (Application.Current != null)
            Application.Current.MainPage = new MainPage();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
            Id_FornecedorLabel.Text      = fornecedor.Id_Fornecedor.ToString();
            CNPJEntry.Text          = fornecedor.CNPJ;
            EndereçoEntry.Text      = fornecedor.Endereço;
            MateriaPrimaEntry.Text  = fornecedor.MateriaPrima;
            NomeFonecedorEntry.Text      = fornecedor.Nome;
            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            Id_FornecedorLabel.Text = string.Empty;
            CNPJEntry.Text = string.Empty;
            EndereçoEntry.Text = string.Empty;
            MateriaPrimaEntry.Text = string.Empty;
            NomeFonecedorEntry.Text  = string.Empty;
        }

        private async void SalvaDados(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
            {
            // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
            var fornecedor = new Modelos.Fornecedor();
            if (!String.IsNullOrEmpty(Id_FornecedorLabel.Text))
                fornecedor.Id_Fornecedor      = int.Parse(Id_FornecedorLabel.Text);
            else
            fornecedor.Id_Fornecedor      = 0;
            fornecedor.CNPJ      = CNPJEntry.Text;
            fornecedor.Endereço  = EndereçoEntry.Text;
            fornecedor.Nome      = NomeFonecedorEntry.Text;
            fornecedor.MateriaPrima  =  MateriaPrimaEntry.Text;

            // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
            controleFornecedor.CriarOuAtualizar(fornecedor);
            // Mostra a mensagem de sucesso
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }

         private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            // Verifica se a Entry do Nome está vazia
            if (String.IsNullOrEmpty(NomeFonecedorEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            return false;
            }
            // Verifica se a Entry do Sobrenome está vazia
            else if (String.IsNullOrEmpty(CNPJEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
            return false;
            }
            // Verifica se a Entry do Telefone está vazia
            else if (String.IsNullOrEmpty(EndereçoEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            return false;
            }
            else if (String.IsNullOrEmpty(MateriaPrimaEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            return false;
            }
            else
            return true;
        }

    }
}
