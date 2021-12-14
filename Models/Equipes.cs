using E_Jogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace E_Jogos.Models
{
    public class Equipe : EjogosBase, IEquipe
    {

        private const string path = "Database/equipe.csv";

        public Equipe()
        {

            CreateFolderAndFile(path);

        }

        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }


        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }


        public void Create(Equipe nova_equipe)
        {

            string[] linha = { Prepare(nova_equipe) };
            
            //string[] linha = { $"{nova_equipe.IdEquipe};{nova_equipe.Nome};{nova_equipe.Imagem}" }; ---> outra forma de fazer, sem o Prepare
                        
            File.AppendAllLines(path, linha);
            
        }

        public void Delete(int idEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {

            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(";")[0]);
                equipe.Nome = item.Split(";")[1];
                equipe.Imagem = item.Split(";")[2];

                equipes.Add(equipe);
            }

            return equipes;


        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
