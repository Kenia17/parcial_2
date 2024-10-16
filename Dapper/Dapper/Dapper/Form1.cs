using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;


namespace Dapper
{
    public partial class Form1 : Form
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            var nuevoEmpleado = Crear();
            var insertado = employeeRepository.InsertarEmpleado(nuevoEmpleado);
            MessageBox.Show($"Se han insertado {insertado} registros");
        }

        private Employee Crear()
        {
            Employee nuevo = new Employee
            {
                Name = Names.Text,
                Salary = Salario.Text,
            };
            return nuevo;
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            var cargar = employeeRepository.ObtenerTodo();
            Datos.DataSource = cargar;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Cargar.Text);
            var emplo = employeeRepository.ObtenerPorID(id);
            Datos.DataSource = new List<Employee> { emplo };
        }

        private void BuscarID_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Cargar.Text);
            var emplo = employeeRepository.EliminarEmploye(id);
           
        }
    }
}
