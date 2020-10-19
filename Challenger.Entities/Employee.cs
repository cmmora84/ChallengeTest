using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Challenger.Entities
{
    public class Employee
    {

		public string idField;
		public string nameField;	
		public string contractTypeNameField;
		public string roleIdField;
		public string roleNameField;
		public string roleDescriptionField;
		public int hourlySalaryField;
		public int monthlySalaryField;
		public int annualSalaryField;


		public string id
		{
			get
			{
				return this.idField;
			}

			set
			{
				this.idField = value;
				this.RaisePropertyChanged("id");
			}
		}

		public string name
		{
			get
			{
				return this.nameField;
			}

			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("name");
			}
		}

		public string contractTypeName
		{
			get
			{
				return this.contractTypeNameField;
			}

			set
			{
				this.contractTypeNameField = value;
				this.RaisePropertyChanged("contractTypeName");
			}
		}

		public string roleId
		{
			get
			{
				return this.roleIdField;
			}

			set
			{
				this.roleIdField = value;
				this.RaisePropertyChanged("roleId");
			}
		}

		public string roleName
		{
			get
			{
				return this.roleNameField;
			}

			set
			{
				this.roleNameField = value;
				this.RaisePropertyChanged("roleName");
			}
		}

		public string roleDescription
		{
			get
			{
				return this.roleDescriptionField;
			}

			set
			{
				this.roleDescriptionField = value;
				this.RaisePropertyChanged("roleDescription");
			}
		}

		public int hourlySalary
		{
			get
			{
				return this.hourlySalaryField;
			}

			set
			{
				this.hourlySalaryField = value;
				this.RaisePropertyChanged("hourlySalary");
			}
		}

		public int monthlySalary
		{
			get
			{
				return this.monthlySalaryField;
			}

			set
			{
				this.monthlySalaryField = value;
				this.RaisePropertyChanged("monthlySalary");
			}
		}

		public int annualSalary
		{
			get
			{
				return this.annualSalaryField;
			}

			set
			{
				this.annualSalaryField = value;
				this.RaisePropertyChanged("annualSalary");
			}
		}

		// <summary>
		/// Evento property changed.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Evento property changed.
		/// </summary>
		/// <param name="propertyName">Propiedad que se modifico.</param>
		/// <value>Tipo de resultado.</value>
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

	}
}
