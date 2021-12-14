using System.IO;

namespace E_Jogos.Models
{
    public class EjogosBase
    {

        //criar uma função para criar a pasta e o arquivo
        //string path é o parametro da função, que terá
        //o caminho para analise
        public void CreateFolderAndFile(string path)
        {
            // pasta / arquivo.csv

            string folder = path.Split('/')[0]; // recebe o nome da pasta
            string file = path.Split('/')[1]; // recebe o nome do arquivo

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }


            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
