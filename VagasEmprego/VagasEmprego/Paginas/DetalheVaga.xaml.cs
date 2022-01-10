using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasEmprego.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VagasEmprego.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheVaga : ContentPage
    {
        public DetalheVaga(Vaga vaga)
        {
            InitializeComponent();

            DisplayAlert("Mensagem", vaga.NomeVaga, "Ok");
        }
    }
}