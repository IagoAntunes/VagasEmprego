using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasEmprego.Banco;
using Xamarin.Forms;
using System.IO;
using VagasEmprego.UWP.Banco;
using Windows.Storage;

[assembly: Dependency(typeof(Caminho))]
namespace VagasEmprego.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}
