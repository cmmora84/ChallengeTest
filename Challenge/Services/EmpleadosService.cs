using Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Services
{
	public class EmpleadosService
	{

		public Empleado ObtenerEmpleado(){

			return new Empleado
			{
				id = "1",
				name = "NOMBRE",
				contractTypeName = "TIPO CONTRATO",
				roleId = "ROL ID",
				roleName = "ROL NOMBRE",
				roleDescription = "ROL DESC",
				hourlySalary = "SALARIO HORA",
				monthlySalary = "SALARIO MES"
			};
		
		}

		public List<Empleado> ObtenerEmpleados()
		{

			var empleado1 = new Empleado
			{
				id = "1",
				name = "NOMBRE 1" ,
				contractTypeName = "TIPO CONTRATO",
				roleId = "ROL ID",
				roleName = "ROL NOMBRE",
				roleDescription = "ROL DESC",
				hourlySalary = "SALARIO HORA",
				monthlySalary = "SALARIO MES"
			};

			var empleado2 = new Empleado
			{
				id = "2",
				name = "NOMBRE 2",
				contractTypeName = "TIPO CONTRATO",
				roleId = "ROL ID",
				roleName = "ROL NOMBRE",
				roleDescription = "ROL DESC",
				hourlySalary = "SALARIO HORA",
				monthlySalary = "SALARIO MES"
			};

			return new List<Empleado> { empleado1, empleado2 };

		}
	}
}