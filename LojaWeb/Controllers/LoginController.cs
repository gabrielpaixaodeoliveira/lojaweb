using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text;

namespace LojaWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly string urlApi;
        public LoginController(IConfiguration configuration)
        {
            urlApi = configuration["ApiLoja"]; 
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Login(LoginViewModel credenciais)
        {
            HttpClient client = new HttpClient();
            HttpContent cont = new StringContent(JsonConvert.SerializeObject(credenciais), Encoding.UTF8, "application/json");
            var responsePost = await client.PostAsync($"{urlApi}/usuario/login", cont);
            var result = await responsePost.Content.ReadAsStringAsync();

            if (responsePost.IsSuccessStatusCode)
            {
                TempData["Usuario"] = result;
                return Ok(result);
            }
            else
            {
                return NotFound("Não foi possível encontrar um usuário com os dados informados");
            }
        }
    }
}
