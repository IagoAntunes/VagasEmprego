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
    public partial class EditarVaga : ContentPage
    {
        private Vaga vaga { get; set; }
        public EditarVaga(Vaga vaga)
        {
            InitializeComponent();
            this.vaga = vaga;

            NomeVaga.Text = vaga.NomeVaga;
            Quantidade.Text = vaga.Quantidade.ToString();
            Cidade.Text = vaga.Cidade;
            Descricao.Text = vaga.Descricao;
            Telefone.Text = vaga.Telefone;
            Email.Text = vaga.Email;
            TipoContratacao.IsToggled = (vaga.TipoContratacao == "CLT") ? false : true;

            //TODO - Colocação dos dados na tela

        }
        public void SalvarAction(object sender,EventArgs args)
        {
            //TODO - Obter dados da tela
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Descricao = Descricao.Text;
            vaga.Cidade = Cidade.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            //Atualizar no Banco de dados
            AcessoBanco database = new AcessoBanco();
            database.Atualização(vaga);

            //Redirecionar para tela de minhasvagas
            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());


        }
    }
}