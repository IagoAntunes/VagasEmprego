using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using VagasEmprego.Banco;
using System.IO;
using VagasEmprego.Droid.Banco;
/*Esse atributo serve para registrar no serviço de dependência(DependecyService) do Xamarin a classe Caminho,
 * que irá nos retornar o caminho especifico de cada plataforma para salvar o banco.
 */
[assembly:Dependency(typeof(Caminho))]
namespace VagasEmprego.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoBanco = Path.Combine(caminhoDaPasta,NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}