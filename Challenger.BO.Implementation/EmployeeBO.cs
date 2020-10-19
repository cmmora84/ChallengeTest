using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Challenger.Entities;
using Newtonsoft.Json;


namespace Challenger.BO.Implementation
{
    public class EmployeeBO
    {

		public string obtenerEmpleados(string idEmpleado){

			var json = "";
			
			return json;

		}

		public async Task consumirAPI()
		{

			var json = "";

			var url = "http://masglobaltestapi.azurewebsites.net/api/Employees";

			using (var http = new HttpClient())
			{

				var response = await http.GetStringAsync(url);
				var empleados = JsonConvert.DeserializeObject<List<Employee>>(response);

				foreach(var empleado in empleados ){
					Console.WriteLine($"Empleado Id { empleado.id }");

				}

				Console.ReadLine();
			}

		}

		public int calcularSueldoAnual(){

			Employee empleado = new Employee();
			empleado.contractTypeName = "asdasd";

			var sueldoAnual = 0;

			
			if(empleado.contractTypeName == "HourlySalaryEmployee")
			{
				sueldoAnual = 120 * empleado.hourlySalary * 12;
			} else {

				sueldoAnual = empleado.monthlySalary * 12;
			}

			return sueldoAnual;
			
		}
    }
}
