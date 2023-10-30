using AcademySennaAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcademySennaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        [HttpPost(Name = "CreateFornecedor")]
        public string CreateFornecedor(Aluno objetoFornecedor)
        {
            return "Fornecedor Criado com sucesso";
        }

        [HttpGet(Name = "GetFornecedorByName")]
        public ActionResult GetFornecedorByName(string NomeFrontend)


        {
            var objetoFornecedor = new Fornecedor();
            objetoFornecedor.Nome = "Musculo";
            objetoFornecedor.CNPJ = 12345678901234;
            objetoFornecedor.Endereço = "Rua dos bobos";
            objetoFornecedor.Telefone = 33548493;
            objetoFornecedor.Email = "musculo@mkd.com";


            var objetoFornecedor2 = new Fornecedor();
            objetoFornecedor2.Nome = "Proteina";
            objetoFornecedor2.CNPJ = 487689565545;
            objetoFornecedor2.Endereço = "Rua dos tolos";
            objetoFornecedor2.Telefone = 33548493;
            objetoFornecedor2.Email = "proteina@mkd.com";

            var objetoFornecedor3 = new Fornecedor();
            objetoFornecedor3.Nome = "Maick";
            objetoFornecedor3.CNPJ = 8964179641786;
            objetoFornecedor3.Endereço = "Rua dos caqui";
            objetoFornecedor3.Telefone = 33548493;
            objetoFornecedor3.Email = "maick@mkd.com";

            if (NomeFrontend == objetoFornecedor.Nome)
            {
                return Ok(objetoFornecedor);
            }
            else if (NomeFrontend == objetoFornecedor2.Nome)
            {
                return Ok(objetoFornecedor2);
            }
            else if (NomeFrontend == objetoFornecedor3.Nome)
            {
                return Ok(objetoFornecedor3);
            }

            return Ok("Fornecedor não Econtrado");


        }
    }
}
