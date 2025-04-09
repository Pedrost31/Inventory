using InventoryApp.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace InventoryApp.Repositories
{
    class ProductsRepository
    {
        private readonly string connectionString = "Data Source=DESKTOP-NT0F4J8;Initial Catalog=InventoryAppDB;Integrated Security=True;TrustServerCertificate=True;";

        public List<Products> GetProducts()
        {
            var products = new List<Products>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM produits", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new Products
                                {
                                    id = reader.GetInt32(0),
                                    nom = reader.GetString(1),
                                    description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    prix = Convert.ToDouble(reader.GetDecimal(3)),
                                    stock = reader.GetInt32(4),
                                    seuil_alerte = reader.GetInt32(5),
                                    categorie = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    fournisseur = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    image_link = reader.IsDBNull(8) ? "" : reader.GetString(8) // Récupérer l'image
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return products;
        }

        public Products? GetProduct(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM produits WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Products
                                {
                                    id = reader.GetInt32(0),
                                    nom = reader.GetString(1),
                                    description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    prix = Convert.ToDouble(reader.GetDecimal(3)),
                                    stock = reader.GetInt32(4),
                                    seuil_alerte = reader.GetInt32(5),
                                    categorie = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    fournisseur = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    image_link = reader.IsDBNull(8) ? "" : reader.GetString(8)
                                };
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
        public List<Products> GetAllProducts()
        {
            List<Products> productsList = new List<Products>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand("SELECT * FROM produits", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Products product = new Products
                                {
                                    id = reader.GetInt32(0),
                                    nom = reader.GetString(1),
                                    description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    prix = Convert.ToDouble(reader.GetDecimal(3)),
                                    stock = reader.GetInt32(4),
                                    seuil_alerte = reader.GetInt32(5),
                                    categorie = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    fournisseur = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    image_link = reader.IsDBNull(8) ? "" : reader.GetString(8)
                                };

                                productsList.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return productsList;
        }
        public Products GetLastInsertedProduct()
        {
            Products lastProduct = null;

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL pour récupérer le dernier produit inséré
                    string sql = "SELECT TOP 1 * FROM produits ORDER BY id DESC"; // Récupérer le dernier produit par l'ID

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lastProduct = new Products
                                {
                                    id = reader.GetInt32(0),
                                    nom = reader.GetString(1),
                                    description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    prix = Convert.ToDouble(reader.GetDecimal(3)),
                                    stock = reader.GetInt32(4),
                                    seuil_alerte = reader.GetInt32(5),
                                    categorie = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    fournisseur = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    image_link = reader.IsDBNull(8) ? "" : reader.GetString(8)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lastProduct;
        }

        public Products GetProductById(int details_id)
        {
            Products product = null;

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL pour récupérer le produit par l'ID
                    string sql = "SELECT * FROM produits WHERE id = @id";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        // Ajout du paramètre pour éviter les attaques SQL
                        command.Parameters.AddWithValue("@id", details_id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Récupération des données du produit
                                product = new Products
                                {
                                    id = reader.GetInt32(0),
                                    nom = reader.GetString(1),
                                    description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    prix = Convert.ToDouble(reader.GetDecimal(3)),
                                    stock = reader.GetInt32(4),
                                    seuil_alerte = reader.GetInt32(5),
                                    categorie = reader.IsDBNull(6) ? "" : reader.GetString(6),
                                    fournisseur = reader.IsDBNull(7) ? "" : reader.GetString(7),
                                    image_link = reader.IsDBNull(8) ? "" : reader.GetString(8)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return product;
        }


        public void CreateProduct(Products product)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("INSERT INTO produits (nom, description, prix, stock, seuil_alerte, categorie, fournisseur, image_link) VALUES (@nom, @description, @prix, @stock, @seuil_alerte, @categorie, @fournisseur, @image_link)", connection))
                    {
                        command.Parameters.AddWithValue("@nom", product.nom);
                        command.Parameters.AddWithValue("@description", product.description);
                        command.Parameters.AddWithValue("@prix", product.prix);
                        command.Parameters.AddWithValue("@stock", product.stock);
                        command.Parameters.AddWithValue("@seuil_alerte", product.seuil_alerte);
                        command.Parameters.AddWithValue("@categorie", product.categorie);
                        command.Parameters.AddWithValue("@fournisseur", product.fournisseur);
                        command.Parameters.AddWithValue("@image_link", product.image_link); // Ajouter le lien image
                        command.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Produit ajouté avec succès !");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateProduct(Products product)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("UPDATE produits SET nom = @nom, description = @description, prix = @prix, stock = @stock, seuil_alerte = @seuil_alerte, categorie = @categorie, fournisseur = @fournisseur, image_link = @image_link WHERE id = @id", connection))
                    {
                        command.Parameters.AddWithValue("@id", product.id);
                        command.Parameters.AddWithValue("@nom", product.nom);
                        command.Parameters.AddWithValue("@description", product.description);
                        command.Parameters.AddWithValue("@prix", product.prix);
                        command.Parameters.AddWithValue("@stock", product.stock);
                        command.Parameters.AddWithValue("@seuil_alerte", product.seuil_alerte);
                        command.Parameters.AddWithValue("@categorie", product.categorie);
                        command.Parameters.AddWithValue("@fournisseur", product.fournisseur);
                        command.Parameters.AddWithValue("@image_link", product.image_link);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteProduct(int details_id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("DELETE FROM produits WHERE id = @id", connection))
                    {
                        // Utiliser details_id comme paramètre pour éviter les attaques SQL
                        command.Parameters.AddWithValue("@id", details_id);
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