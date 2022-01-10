using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
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
            _conexao.CreateTable<Vaga>();
        }
        public void Cadastro(Vaga vaga)
        {
            _conexao.Insert(vaga);
        }
        public void Exclusao(Vaga vaga)
        {
            _conexao.Delete(vaga);
        }
        public void Atualização(Vaga vaga)
        {
            _conexao.Update(vaga);
        }
        public List<Vaga> Consultar()
        {
            return _conexao.Table<Vaga>().ToList();
        }
        public List<Vaga> Pesquisar(string palavra)
        {
            return _conexao.Table<Vaga>().Where(a=>a.nomeVaga.Contains(palavra)).ToList();
        }
        public Vaga ObterVagaPorId(int id)
        {
            return _conexao.Table<Vaga>().Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
