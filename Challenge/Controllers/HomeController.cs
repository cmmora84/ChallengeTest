using Challenge.Models;
using Challenge.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Challenge.Controllers
{
	public class HomeController : Controller
	{
		public async Task<ActionResult> Index(string buscar)
		{

			/*
			var empleadosService = new EmpleadosService();
			var model = empleadosService.ObtenerEmpleados();
			return View(model);
			*/


			var httpClient = new HttpClient();
			var json = await httpClient.GetStringAsync("http://masglobaltestapi.azurewebsites.net/api/Employees");

			var EmpleadosListaAPI = JsonConvert.DeserializeObject<List<Empleado>>(json);

			var empleadosService = new EmpleadosService();

			var EmpleadosListaFinal = empleadosService.ObtenerResultados(EmpleadosListaAPI);

			// Filtramos el resultado por el 'texto de búqueda'
			if (!string.IsNullOrEmpty(buscar))
			{
				EmpleadosListaFinal = EmpleadosListaFinal.Where(x => x.id.Contains(buscar)).ToList();
			}

			return View(EmpleadosListaFinal);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}