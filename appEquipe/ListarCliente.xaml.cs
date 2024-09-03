using appEquipe;
using Microsoft.Maui.Controls;

namespace AppEquipe
{
    public partial class ListarCliente : ContentPage
    {
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Handle search button click
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            // Handle edit button click
        }

        private void OnTrashClicked(object sender, EventArgs e)
        {
            // Handle trash button click
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Handle add button click
        }

        private void VoltarMenu (object sender, EventArgs args)
        {
            if (Application.Current != null)
            Application.Current.MainPage = new MainPage();
        }

        
    }
}
