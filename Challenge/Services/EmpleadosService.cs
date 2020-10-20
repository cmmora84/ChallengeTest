using Challenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace Challenge.Services
{
	public class EmpleadosService
	{
	
		public List<Empleado> ObtenerResultados(List<Empleado>  ListaAPI )
		{

			var listaReturn = new List<Empleado> {};

			foreach(var empleado in ListaAPI){

				var empleadoAux = new Empleado();

				empleadoAux.id = empleado.id;
				empleadoAux.name = empleado.name;
				empleadoAux.contractTypeName = empleado.contractTypeName;
				empleadoAux.roleId = empleado.roleId;
				empleadoAux.roleName = empleado.roleName;
				empleadoAux.roleDescription = empleado.roleDescription;
				empleadoAux.hourlySalary = empleado.hourlySalary;
				empleadoAux.monthlySalary = empleado.monthlySalary;

				if (empleado.contractTypeName == "HourlySalaryEmployee")
				{
					empleadoAux.annualSalary = 120 * empleado.hourlySalary * 12;
				}
				else
				{

					empleadoAux.annualSalary = empleado.monthlySalary * 12;
				}

				listaReturn.Add(empleadoAux);

			}

			return listaReturn;
			
		}

		public async Task consumirAPI()
		{

			var url = "http://masglobaltestapi.azurewebsites.net/api/Employees";

			var http = new HttpClient();

			var json = await http.GetStringAsync(url);

			var listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(json);

			var a = "a";

		}

	}
}