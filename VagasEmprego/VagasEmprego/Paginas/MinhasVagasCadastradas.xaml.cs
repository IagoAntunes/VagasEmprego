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
    public partial class MinhasVagasCadastradas : ContentPage
    {
        List<Vaga> Lista { get; set; }
        public MinhasVagasCadastradas()
        {
            InitializeComponent();
            ConsultarVagas();
        }
        private void ConsultarVagas()
        {
            AcessoBanco Database = new AcessoBanco();
            Lista = Database.Consultar();
            listaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();
        }
        public void EditarAction(object sender,EventArgs args) 
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new EditarVaga(vaga));
        }
        public void ExcluirAction(object sender,EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            AcessoBanco Database = new AcessoBanco();
            Database.Exclusao(vaga);

            ConsultarVagas();
        }
    }
}