using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MontagemCurriculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontagemCurriculo.Controllers
{
    public class InformacoesLoginController : Controller
    {

        private readonly Contexto _cotexto;

        public InformacoesLoginController(Contexto contexto)
        {
            _cotexto = contexto;
        }



        public async Task<IActionResult> Index()
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");

           
            return View( await _cotexto.InformacoesLogin.Include(u => u.Usuario).Where(i => i.UsuarioId == usuarioId).ToListAsync());
        }

        public IActionResult DowloadDados()
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");
            var dados = _cotexto.InformacoesLogin.Include(u => u.Usuario).Where(i => i.UsuarioId == usuarioId).ToList();
            StringBuilder arquivo = new StringBuilder();

            arquivo.AppendLine("EnderecoIP;Data;Horario");

            foreach (var item in dados)
            {
                arquivo.AppendLine(item.EnderecoIP + ";" + item.Data + ";" + item.Horario);

            }

            return File(Encoding.ASCII.GetBytes(arquivo.ToString()), "text/csv", "dados.csv");

        }


    }
}
