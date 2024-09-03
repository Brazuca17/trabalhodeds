using AppEquipe;

namespace appEquipe;

public partial class MainPage : ContentPage
{
      public MainPage()
      {
        InitializeComponent();
      }

      private void IrCadastroCliente (object sender, EventArgs args)
      {
        if (Application.Current != null)
          Application.Current.MainPage = new CadastroCliente();
      }

      private void IrCadastroFornecedor (object sender, EventArgs args)
      {
        if (Application.Current != null)
          Application.Current.MainPage = new CadastroFornecedor();
      }
      
      private void IrCadastroMateriaPrima (object sender, EventArgs args)
      {
        if (Application.Current != null)
          Application.Current.MainPage = new CadastroMateriaPrima();
      }

      private void IrListarMateriaPrima (object sender, EventArgs args)
      {
        if (Application.Current != null)
          Application.Current.MainPage = new ListarMateriaPrima();
      }

      private void IrListarCliente (object sender, EventArgs args)
      {
        if (Application.Current != null)
          Application.Current.MainPage = new ListarCliente();
      }

      private void IrListarFornecedor (object sender, EventArgs args)
      {
        if (Application.Current != null)
          Application.Current.MainPage = new ListarFornecedor();
      }

	
	
}

