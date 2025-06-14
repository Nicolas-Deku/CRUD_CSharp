using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.classe
{
    class DatabaseVoiture
    {
        // Change la chaîne de connexion selon ta config
        private static string connectionString = "Host=localhost;Port=5432;Database=exemple;Username=postgres;Password=deku2002";


        public static void EnregistrerVoiture(Voiture v)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"INSERT INTO voiture (matricule, marque, modele, annee, prix, image_path)
                           VALUES (@matricule, @marque, @modele, @annee, @prix, @image_path)";

                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("matricule", v.Matricule);
                    cmd.Parameters.AddWithValue("marque", v.Marque);
                    cmd.Parameters.AddWithValue("modele", v.Modele);
                    cmd.Parameters.AddWithValue("annee", v.Annee);
                    cmd.Parameters.AddWithValue("prix", v.Prix);
                    cmd.Parameters.AddWithValue("image_path", v.ImagePath);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModifierVoiture(Voiture v)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"UPDATE voiture SET 
                        matricule = @matricule,
                        marque = @marque,
                        modele = @modele,
                        annee = @annee,
                        prix = @prix,
                        image_path = @image_path
                       WHERE id = @id";

                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("matricule", v.Matricule);
                    cmd.Parameters.AddWithValue("marque", v.Marque);
                    cmd.Parameters.AddWithValue("modele", v.Modele);
                    cmd.Parameters.AddWithValue("annee", v.Annee);
                    cmd.Parameters.AddWithValue("prix", v.Prix);
                    cmd.Parameters.AddWithValue("image_path", v.ImagePath ?? "");
                    cmd.Parameters.AddWithValue("id", v.Id); // ⚠️ Tu dois connaître l'id !

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SupprimerVoiture(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM voiture WHERE id = @id";

                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Voiture> GetAllVoitures()
        {
            List<Voiture> voitures = new List<Voiture>();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT id, matricule, marque, modele, annee, prix, image_path FROM voiture";

                    using (var cmd = new NpgsqlCommand(sql, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                Voiture v = new Voiture(
                                    id: reader.GetInt32(0),
                                    matricule: reader.GetString(1),
                                    marque: reader.GetString(2),
                                    modele: reader.GetString(3),
                                    annee: reader.GetInt32(4),
                                    prix: reader.GetDecimal(5),
                                    imagePath: reader.IsDBNull(6) ? "" : reader.GetString(6)
                                );
                                voitures.Add(v);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Erreur création voiture: {ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur connexion base de données: {ex.Message}");
            }

            return voitures;
        }



    }
}
