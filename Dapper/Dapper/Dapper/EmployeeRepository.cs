using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace Dapper
{
    public class EmployeeRepository
    {
        public List<Employee> ObtenerTodo()
        {
            using (var conexion = Database.GetSqlConnection())
            {
                string selectAll = "";
                selectAll += "SELECT [EmployeeID] " + "\n";
                selectAll += "      ,[Name] " + "\n";
                selectAll += "      ,[Salary] " + "\n";
                selectAll += "  FROM [dbo].[Employees]";

                var empleados = conexion.Query<Employee>(selectAll).ToList();
                return empleados;
            }
        }
        public Employee ObtenerPorID(int id) 
        {
            using (var conexion = Database.GetSqlConnection())
            {
                string selectPorID = @"
            SELECT [EmployeeID],
                   [Name],
                   [Salary]
            FROM [dbo].[Employees]
            WHERE EmployeeID = @EmployeeID";  

                
                var empleado = conexion.QueryFirstOrDefault<Employee>(selectPorID, new { EmployeeID = id });
                return empleado;
            }
        }


        public int InsertarEmpleado(Employee employee)
        {
            using (var conexion = Database.GetSqlConnection())
            {
                string insertar = "";
                insertar += "INSERT INTO [dbo].[Employees] " + "\n";
                insertar += "           ([Name] " + "\n";
                insertar += "           ,[Salary]) " + "\n";
                insertar += "     VALUES " + "\n";
                insertar += "           (@name " + "\n";
                insertar += "           ,@salary)";
                
                var insertadas = conexion.Execute(insertar, new
                {
                    name = employee.Name,
                    salary = employee.Salary
                });

                return insertadas;
            }
        }

        public int EliminarEmploye(int id)
        {
            using (var conexion = Database.GetSqlConnection())
            {
                string borrar = "";
                borrar = borrar + "DELETE FROM [dbo].[Employees]" + "\n";
                borrar = borrar + "WHERE EmployeeID = @Id";

                var eliminados = conexion.Execute(borrar, new
                {
                    id = id
                });
                 return eliminados;
            }
        }

    }
}
