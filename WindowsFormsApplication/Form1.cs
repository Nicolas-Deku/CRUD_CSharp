using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication.classe;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private string cheminImage = null;
        public Form1()
        {
            InitializeComponent();
            tbliste.AutoGenerateColumns = false;
            ConfigureDataGridViewColumns();
            ChargerVoitures();
            fermer();
        }

        private void btnparccour_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisir une image";
            ofd.Filter = "Images (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string cheminOriginal = ofd.FileName;
                string dossierDestination = Path.Combine(Application.StartupPath, "resources", "images");

                if (!Directory.Exists(dossierDestination))
                    Directory.CreateDirectory(dossierDestination);

                string nomFichier = Guid.NewGuid().ToString() + Path.GetExtension(cheminOriginal);
                cheminImage = Path.Combine(dossierDestination, nomFichier); // Stocke le chemin complet

                try
                {
                    File.Copy(cheminOriginal, cheminImage);
                    plafficheimage.Image = Image.FromFile(cheminImage);
                    plafficheimage.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la copie de l'image: " + ex.Message);
                    cheminImage = null;
                }
            }
        }

        private void btnenreg_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtprix.Text, out decimal prix) || !int.TryParse(txtannee.Text, out int annee))
            {
                MessageBox.Show("Veuillez entrer des valeurs valides pour le prix et l'année");
                return;
            }

            Voiture v = new Voiture
            {
                Matricule = txtmatricule.Text,
                Marque = txtmarque.Text,
                Modele = txtmodele.Text,
                Annee = annee,
                Prix = prix,
                ImagePath = cheminImage ?? ""
            };

            try
            {
                DatabaseVoiture.EnregistrerVoiture(v);
                MessageBox.Show("Voiture enregistrée avec succès !");
                cheminImage = null; 
                plafficheimage.Image = null;
                ChargerVoitures();
                effacechamp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
             
    try
    {
        Voiture v = new Voiture
        {
            Id = int.Parse(txtid.Text),
            Matricule = txtmatricule.Text,
            Marque = txtmarque.Text,
            Modele = txtmodele.Text,
            Annee = int.Parse(txtannee.Text),
            Prix = decimal.Parse(txtprix.Text),
            ImagePath = cheminImage ?? ""
        };

        DatabaseVoiture.ModifierVoiture(v);
        MessageBox.Show("Voiture modifiée avec succès !");
        btnenreg.Show();
                ChargerVoitures();
                fermer();
                effacechamp();
            }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur : " + ex.Message);
    }

        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            
    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette voiture ?", "Confirmation", MessageBoxButtons.YesNo);

    if (result == DialogResult.Yes)
    {
        try
        {
            DatabaseVoiture.SupprimerVoiture(id);
            MessageBox.Show("Voiture supprimée avec succès !");
            btnenreg.Show();
            ChargerVoitures();
                    fermer();
                    effacechamp();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur : " + ex.Message);
        }
    }
        }


        private void ChargerVoitures()
        {
            try
            {
                var liste = DatabaseVoiture.GetAllVoitures();

                if (liste.Count == 0)
                {
                    MessageBox.Show("Aucune voiture trouvée dans la base de données.");
                    return;
                }

                var bindingSource = new BindingSource();
                bindingSource.DataSource = liste;
                tbliste.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }

        private void tbliste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnenreg.Hide();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tbliste.Rows[e.RowIndex];

                txtmatricule.Text = row.Cells["colMatricule"].Value.ToString();
                txtmarque.Text = row.Cells["colMarque"].Value.ToString();
                txtmodele.Text = row.Cells["colModele"].Value.ToString();
                txtannee.Text = row.Cells["colAnnee"].Value.ToString();
                txtprix.Text = row.Cells["colPrix"].Value.ToString();
                string imagePath = row.Cells["colImagePath"].Value?.ToString() ?? "";

                txtid.Text = row.Cells["colId"].Value.ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        plimage.BackgroundImage = Image.FromFile(imagePath);
                    }
                    catch
                    {
                        plimage.BackgroundImage = null;
                    }
                }
                else
                {
                    plimage.BackgroundImage = null;
                }
            }
            afficher();
        }
        private void afficher()
        {
            btnsupp.Show();
            btnmodif.Show();
        }
        private void fermer()
        {
            btnsupp.Hide();
            btnmodif.Hide();
        }
        private void effacechamp()
        {
            txtid.Text = "";
            txtmatricule.Text = "";
            txtmodele.Text = "";
            txtprix.Text = "";
            txtmarque.Text = "";
            txtannee.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConfigureDataGridViewColumns()
        {
            // Effacer les colonnes existantes
            tbliste.Columns.Clear();

            // Ajouter les colonnes avec les bons noms
            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colMatricule",
                DataPropertyName = "Matricule",
                HeaderText = "Matricule"
            });

            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colMarque",
                DataPropertyName = "Marque",
                HeaderText = "Marque"
            });

            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colModele",
                DataPropertyName = "Modele",
                HeaderText = "Modèle"
            });

            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colAnnee",
                DataPropertyName = "Annee",
                HeaderText = "Année"
            });

            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colPrix",
                DataPropertyName = "Prix",
                HeaderText = "Prix",
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "N2" }
            });

            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colImagePath",
                DataPropertyName = "ImagePath",
                HeaderText = "Chemin Image",
                Visible = false // On cache cette colonne
            });

            tbliste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                DataPropertyName = "Id",
                HeaderText = "ID",
                Visible = false // On cache l'ID
            });
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            effacechamp();
        }
    }

}
