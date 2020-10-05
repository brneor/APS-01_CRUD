using APS01_CRUD.ViewModels;
using APS01_Dominio.Models;
using System.Windows;

namespace APS01_CRUD.Views
{
    /// <summary>
    /// Interaction logic for ProdutoListaView.xaml
    /// </summary>
    public partial class ProdutoListaView : Window
    {
        public ProdutoListaView()
        {
            InitializeComponent();

            DataContext = new ProdutoViewModel(new TelaCadastroApresentacao<Produto, ProdutoView>());
        }
    }
}
