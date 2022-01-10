using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasEmprego.Modelos;
using VagasEmprego.Banco;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasEmprego.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroVaga : ContentPage
    {
        public CadastroVaga()
        {
            InitializeComponent();
        }
        private void SalvarAction(object sender,EventArgs args)
        {
            //TODO - Obter dados da tela
            Vaga vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Descricao = Descricao.Text;
            vaga.Cidade = Cidade.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            //TODO - Salvar informações no banco
            AcessoBanco database = new AcessoBanco();
            database.Cadastro(vaga);

            //TODO - Voltar para tela de pesquisa
            //Navigation.PopAsync();
            App.Current.MainPage = new NavigationPage(new ConsultaVagas());

        }
    }
}