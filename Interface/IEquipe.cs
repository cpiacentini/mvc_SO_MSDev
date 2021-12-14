using E_Jogos.Models;
using System.Collections.Generic;

namespace E_Jogos.Interface
{
    public interface IEquipe
    {

        void Create(Equipe nova_equipe);

        List<Equipe> ReadAll();
        
        void Update(Equipe equipe);

        void Delete(int idEquipe);



    }
}
