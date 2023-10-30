
using AcademySennaAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcademySennaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase

    {

    [HttpGet(Name = "GetFuncionarioByName")]
    public ActionResult GetFuncionarioByName(string NomeFrontend)

    {
        var objetoFuncionario = new Funcionario();
        objetoFuncionario.Matricula = 1234;
        objetoFuncionario.Nome = "Everton";
        objetoFuncionario.Cargo = "Gerente";
        objetoFuncionario.Salário = 4500;


        var objetoFuncionario2 = new Funcionario();
        objetoFuncionario2.Matricula = 1234434;
        objetoFuncionario2.Nome = "Patricia";
        objetoFuncionario2.Cargo = "Supervisora";
        objetoFuncionario2.Salário = 3000;

        var objetoFuncionario3 = new Funcionario();
        objetoFuncionario3.Matricula = 1234353;
        objetoFuncionario3.Nome = "Gabrielly";
        objetoFuncionario3.Cargo = "Recepcionista";
        objetoFuncionario3.Salário = 2000;

            if (NomeFrontend == objetoFuncionario.Nome)
        {
            return Ok(objetoFuncionario);
        }
        else if (NomeFrontend == objetoFuncionario2.Nome)
        {
            return Ok(objetoFuncionario2);
        }
        else if (NomeFrontend == objetoFuncionario3.Nome)
        {
            return Ok(objetoFuncionario3);
        }

        return Ok("Fincionario não Econtrado");


    }
    }
}



    