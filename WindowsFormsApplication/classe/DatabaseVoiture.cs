using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication.classe
{
    class DatabaseVoiture
    {
        // Change la chaîne de connexion selon ta config
        private static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Deku\Documents\Visual Studio 2013\Projects\WindowsFormsApplication\WindowsFormsApplication\exemple.mdf;Integrated Security=True";


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
                    cmd.Parameters.AddWithValue("image_path", v.Prix);

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

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT id, matricule, marque, modele, annee, prix, image_path FROM voiture";

                using (var cmd = new NpgsqlCommand(sql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Voiture v = new Voiture(
                            matricule: reader.GetString(1),
                            marque: reader.GetString(2),
                            modele: reader.GetString(3),
                            annee: reader.GetInt32(4),
                            prix: reader.GetDecimal(5),
                            imagePath: reader.IsDBNull(6) ? "" : reader.GetString(6),
                            id: reader.GetInt32(0)
                        );

                        voitures.Add(v);
                    }
                }
            }

            return voitures;
        }



    }
}
