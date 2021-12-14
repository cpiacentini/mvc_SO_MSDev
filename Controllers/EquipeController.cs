using E_Jogos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Jogos.Controllers
{
    public class EquipeController : Controller
    {

        Equipe equipeModel = new Equipe();


        public IActionResult Index()
        {

            //IActionResult resaponsável por devoler o status HTTP

            ViewBag.Equipes = equipeModel.ReadAll();
            
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Nome = form["Nome"];
            nova_equipe.Imagem = form["Imagem"];

            equipeModel.Create(nova_equipe);

            ViewBag.Equipes = equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");

        }
    }
}
