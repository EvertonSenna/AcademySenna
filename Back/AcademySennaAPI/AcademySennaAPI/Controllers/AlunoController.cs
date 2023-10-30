using AcademySennaAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcademySennaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpPost(Name = "CreateAluno")]
        public string CreateAluno(Aluno objetoAluno)
        {
            return "Aluno Criado com sucesso";
        }

        [HttpGet(Name = "GetAlunoByName")]
        public ActionResult GetAlunoByName(string NomeFrontend)


        {
            var objetoAluno = new Aluno();
            objetoAluno.Matricula = 1234;
            objetoAluno.Nome = "Everton";
            objetoAluno.Modalidade = "CrossFit";
            objetoAluno.Idade = 34;

            var objetoAluno2 = new Aluno();
            objetoAluno2.Matricula = 1234;
            objetoAluno2.Nome = "Patricia";
            objetoAluno2.Modalidade = "Natação";
            objetoAluno2.Idade = 41;

            var objetoAluno3 = new Aluno();
            objetoAluno3.Matricula = 1234;
            objetoAluno3.Nome = "Gabrielly";
            objetoAluno3.Modalidade = "Musculação";
            objetoAluno3.Idade = 18;

            if (NomeFrontend == objetoAluno.Nome)
            {
                return Ok(objetoAluno);
            }
            if (NomeFrontend == objetoAluno2.Nome)
            {
                return Ok(objetoAluno2);
            }
            if (NomeFrontend == objetoAluno3.Nome)
            {
                return Ok(objetoAluno3);
            }
            return Ok("Aluno não econtrado");
        }


    }
}
