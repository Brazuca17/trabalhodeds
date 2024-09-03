using Microsoft.Maui.Controls;
using System;

namespace appEquipe
{
    public partial class CadastroFornecedor : ContentPage
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cadastro", "Cadastro Realizado com Sucesso!", "OK");
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Add your logic for the Register button click event here
            DisplayAlert("Cadastro", "Cadastro Realizado com Sucesso!", "OK");
        }

         private void VoltarMenu (object sender, EventArgs args)
        {
            if (Application.Current != null)
            Application.Current.MainPage = new MainPage();
        }

    }
}
