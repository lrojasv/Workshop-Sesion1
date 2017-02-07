using System.Collections.Generic;
using System.Web.Mvc;
using WorkshopUsuarios.Models;

namespace WorkshopUsuarios.Controllers
{
    public class UsuarioController : Controller
    {

        private static List<Usuario> RepositorioUsuario { get; set; }

        public ActionResult Index()
        {
            LlenarRepositorioUsuario();
            return View(RepositorioUsuario);
        }

        private void LlenarRepositorioUsuario()
        {
            RepositorioUsuario = new List<Usuario>
            {
                new Usuario
                {
                    Id = 1,
                    Nombre = "Luis",
                    ApellidoPaterno = "Rojas",
                    ApellidoMaterno = "Vásquez"
                },
                new Usuario
                {
                    Id = 2,
                    Nombre = "Juan",
                    ApellidoPaterno = "Perez",
                    ApellidoMaterno = "Carranza"
                },
                new Usuario
                {
                    Id = 3,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Dávila",
                    ApellidoMaterno = "Lazón"
                }
            };
        }
	}
}