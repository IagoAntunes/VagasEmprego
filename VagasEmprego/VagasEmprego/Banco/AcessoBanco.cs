using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using VagasEmprego.Modelos;
using Xamarin.Forms;

namespace VagasEmprego.Banco
{
    public class AcessoBanco
    {
        private SQLiteConnection _conexao;
        public AcessoBanco()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
        }
        public void Cadastro(Vaga vaga)
        {

        }
        public void Exclusao(int id)
        {

        }
        public void Atualização(Vaga vaga)
        {

        }
        public List<Vaga> Consultar()
        {
            return null;
        }
        public Vaga ObterVagaPorId(int id)
        {
            return null;
        }
    }
}
