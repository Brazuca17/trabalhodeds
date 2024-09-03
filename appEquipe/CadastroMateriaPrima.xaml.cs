using Microsoft.Maui.Controls;
using System;

namespace appEquipe
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Save button clicked", "OK");
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cadastro", "Matéria-Prima Cadastrada com Sucesso!","OK");
        }

        private async void FrameDeApagar(object sender, EventArgs args)
        {
            var resp=await DisplayAlert("Apagar", "Tem Certeza?", "Sim", "Não");
        }

        private async void FrameDeAtualizar(object sender, EventArgs args)
        {
            var resp=await DisplayAlert("Atualizar", "Tem Certeza?", "Sim", "Não");
        }

        private async void FrameDeSalvar(object sender, EventArgs args)
        {
            var resp=await DisplayAlert("Salvar", "Tem Certeza?", "Sim", "Não");
        }

         private void VoltarMenu (object sender, EventArgs args)
        {
            if (Application.Current != null)
            Application.Current.MainPage = new MainPage();
        }
    }
}
