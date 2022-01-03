using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlMvcOffice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();
            string connectionString = "Data Source=MOE-2032526703;Initial Catalog=OfficeSqlDb;Integrated Security=True;Pooling=False";
            //getEmployeeData(connectionString);
            AddEmployeeData(connectionString);
            //UpdateEmployee(connectionString);
            //DeleteEmployee(connectionString);
        }

        public static void getEmployeeData(string connectionString)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Employee";
                    sqlCommand command = new sqlCommand(query, connection);
                    SqlDataReader dataFromDb = command.ExecuteReader();
                    if (dataFromDb.HasRows)
                    {
                        while (dataFromDb.Read())
                        {
                            //Console.WriteLine(dataFromDb.GetString(1));
                            //Console.WriteLine(dataFromDb.GetDateTime(2));
                            //Console.WriteLine(dataFromDb.GetString(3));
                            //Console.WriteLine(dataFromDb.GetInt32(4));
                        }

                    }
                    else
                    {
                        Console.WriteLine("no rows");
                    }
                    connection.Close();
                }
            }
            catch (SqlException X)
            {
                Console.WriteLine(X.Message);

            }
            catch (Exception)
            {
                Console.WriteLine("there is generlic problem");
            }
            Console.ReadLine();
        }
        private static void AddEmployeeData(string connectionString)
        {
            Console.WriteLine("name");
            string fName = Console.ReadLine();
            Console.WriteLine("birthDay");
            string birthDate = Console.ReadLine();
            Console.WriteLine("mail");
            string mail = Console.ReadLine();
            Console.WriteLine("salary");
            int salary = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"INSERT INTO Employee(fName,birthDate,mail,salary
                    ) VALUES('{fName}','{birthDate}','{mail}','{salary}')";
                    //string query = @"SELECT * FROM Employee";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowEffect = command.ExecuteNonQuery();
                    Console.WriteLine($"row Effect  {rowEffect}");
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("error in the sql");

            }
            catch (Exception)
            {
                Console.WriteLine("general error");
            }
            Console.ReadLine();
        }
        private static void UpdateEmployee(string connectionString)
        {

            Console.WriteLine("name");
            string fName = Console.ReadLine();
            Console.WriteLine("birthDay");
            string birthDate = Console.ReadLine();
            Console.WriteLine("mail");
            string mail = Console.ReadLine();
            Console.WriteLine("salary");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Id");
            int Id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"UPDATE Employee SET fName = '{fName}' ,birthDate = '{birthDate}' ,mail = '{mail}',salary = '{salary}'
WHERE Id = {Id}";
                    //string query = @"SELECT * FROM Employee";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowEffect = command.ExecuteNonQuery();
                    Console.WriteLine($"row Effect  {rowEffect}");
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("error in the sql");

            }
            catch (Exception)
            {
                Console.WriteLine("general error");
            }
            Console.ReadLine();
        }
        private static void DeleteEmployee(string connectionString)
        {
            Console.WriteLine("Id");
            int Id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"DELETE FROM Employee WHERE Id = {Id}";
                    //string query = @"SELECT * FROM Employee";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowEffect = command.ExecuteNonQuery();
                    Console.WriteLine($"row Effect  {rowEffect}");
                    connection.Close();
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("error in the sql");

            }
            catch (Exception)
            {
                Console.WriteLine("general error");
            }
            Console.ReadLine();
        }
    }
    }








