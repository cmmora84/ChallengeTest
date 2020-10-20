﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge.Models
{
	public class Empleado
	{

		public string id {get; set; }
		public string name { get; set; }
		public string contractTypeName { get; set; }
		public string roleId { get; set; }
		public string roleName { get; set; }
		public string roleDescription { get; set; }
		public decimal hourlySalary { get; set; }
		public decimal monthlySalary { get; set; }
		public decimal annualSalary { get; set; }

	}
}