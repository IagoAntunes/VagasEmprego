using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasEmprego.Banco;
using VagasEmprego.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasEmprego.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public ConsultaVagas()
        {
            InitializeComponent();

            AcessoBanco database = new AcessoBanco();
            var Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;
            lblCount.Text = Lista.Count.ToString();
        }
        private void GoCadastro(object sender,EventArgs args)
        {
            Navigation.PushAsync(new CadastroVaga());
        }
        private void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }
        private void MaisDetalheAction(object sender,EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new DetalheVaga(vaga));
        }
   
    
    
    }
}