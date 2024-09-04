using System;
using Modelos;
using Microsoft.Maui.Controls;

namespace appEquipe
{
    public partial class CadastroCliente : ContentPage
    {

        public Cliente cliente { get; set; }
        Controle.ClienteControle clienteControle = new Controle.ClienteControle();

        public CadastroCliente()
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

            if (cliente != null)
            {
            IdLabel.Text        = cliente.idCliente.ToString();
            NomeEntry.Text      = cliente.Nome;
            SobrenomeEntry.Text = cliente.Sobrenome;
            TelefoneEntry.Text  = cliente.Telefone;
            CpfEntry.Text  = cliente.Cpf;
            }
        }

        private void ApagarDados(object sender, EventArgs e)
        {
            CpfEntry.Text = string.Empty;
            NomeEntry.Text = string.Empty;
            SobrenomeEntry.Text = string.Empty;
            TelefoneEntry.Text = string.Empty;
            CpfEntry.Text = string.Empty;
        }

        private async void QuandoSalvarDadosClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
            {
            // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
            var cliente = new Modelos.Cliente();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                cliente.idCliente      = int.Parse(IdLabel.Text);
            else
                cliente.idCliente      = 0;
            cliente.Nome      = NomeEntry.Text;
            cliente.Sobrenome = SobrenomeEntry.Text;
            cliente.Telefone  = TelefoneEntry.Text;
            cliente.Cpf       = CpfEntry.Text;

            // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
            clienteControle.CriarOuAtualizar(cliente);
            // Mostra a mensagem de sucesso
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }

        }

         private async Task<bool> VerificaSeDadosEstaoCorretos()
         {
            // Verifica se a Entry do Nome está vazia
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            return false;
            }
            // Verifica se a Entry do Sobrenome está vazia
            else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
            return false;
            }
            // Verifica se a Entry do Telefone está vazia
            else if (String.IsNullOrEmpty(TelefoneEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            return false;
            }
            else
            return true;
         }





    }


}