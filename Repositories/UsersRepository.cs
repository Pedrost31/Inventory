using InventoryApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Repositories
{
   public class UsersRepository
    {
        private readonly string connectionString = "Data Source=DESKTOP-NT0F4J8;Initial Catalog=InventoryAppDB;Integrated Security=True;TrustServerCertificate=True;";



        public List<Users> GetUsers()
        {
            var users = new List<Users>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM utilisateurs", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new Users
                                {
                                    id = reader.GetInt32(0),
                                    name = reader.GetString(1),
                                    email = reader.GetString(2),
                                    password = reader.GetString(3),
                                    role = reader.GetString(4)
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return users;
        }

        public Users? GetUsers(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM utilisateurs WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Users users = new Users();
                                users.id = reader.GetInt32(0);
                                users.name = reader.GetString(1);
                                users.email = reader.GetString(2);
                                users.password = reader.GetString(3);
                                users.role = reader.GetString(4);
                                return users;

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return null;
        }

        public void CreateUsers(Users users)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO utilisateurs (nom, email, mot_de_passe, role) VALUES (@name, @email, @password, @role)", connection))
                    {
                        command.Parameters.AddWithValue("@name", users.name);
                        command.Parameters.AddWithValue("@email", users.email);
                        command.Parameters.AddWithValue("@password", users.password);
                        command.Parameters.AddWithValue("@role", users.role);
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine(users.role, users.name, users.password, users.role);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateUsers(Users users)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("UPDATE utilisateurs SET nom = @name, email = @email, mot_de_passe = @password, role = @role WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", users.id);
                        command.Parameters.AddWithValue("@name", users.name);
                        command.Parameters.AddWithValue("@email", users.email);
                        command.Parameters.AddWithValue("@password", users.password);
                        command.Parameters.AddWithValue("@role", users.role);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteUsers(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("DELETE FROM utilisateurs WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}
