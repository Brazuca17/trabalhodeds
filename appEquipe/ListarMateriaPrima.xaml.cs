using Microsoft.Maui.Controls;

namespace appEquipe
{
    public partial class ListarMateriaPrima : ContentPage
    {
        public ListarMateriaPrima()
        {
            InitializeComponent();
        }

        private void OnTrashClicked(object sender, EventArgs e)
        {
            // Handle trash button click
        }

        private void OnRecycleClicked(object sender, EventArgs e)
        {
            // Handle recycle button click
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Handle back button click
        }

         private void VoltarMenu (object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new MainPage();
  }
    }
}
