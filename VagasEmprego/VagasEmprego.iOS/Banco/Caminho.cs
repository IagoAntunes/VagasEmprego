using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using VagasEmprego.Banco;
using VagasEmprego.iOS.Banco;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace VagasEmprego.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta,"..","Library");

            string caminhoBanco = Path.Combine(caminhoDaBiblioteca,NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}