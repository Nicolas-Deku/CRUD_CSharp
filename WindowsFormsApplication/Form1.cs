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
            ChargerVoitures();
        }

        private void btnparccour_Click(object sender, EventArgs e)
        {
            // 1. Ouvrir le dialogue pour choisir une image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisir une image";
            ofd.Filter = "Images (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string cheminOriginal = ofd.FileName;

                // 2. Dossier de destination
                string dossierDestination = Path.Combine(Application.StartupPath, "resources", "images");
                if (!Directory.Exists(dossierDestination))
                    Directory.CreateDirectory(dossierDestination);

                // 3. Nom unique pour l’image
                string nomFichier = Guid.NewGuid().ToString() + Path.GetExtension(cheminOriginal);
                string cheminDestination = Path.Combine(dossierDestination, nomFichier);

                // 4. Copier l'image
                File.Copy(cheminOriginal, cheminDestination);

                // 5. Afficher l'image dans le PictureBox
                plafficheimage.Image = new System.Drawing.Bitmap(cheminDestination);
                plafficheimage.SizeMode = PictureBoxSizeMode.Zoom;

                // Optionnel : stocker le chemin dans une variable ou base de données
                MessageBox.Show("Image importée avec succès !");
            }
        }

        private void btnenreg_Click(object sender, EventArgs e)
        {

            decimal prix = decimal.Parse(txtprix.Text);
            int annee = int.Parse(txtannee.Text);
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
                tbliste.DataSource = null; 
                tbliste.DataSource = liste;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void tbliste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnenreg.Hide();
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = tbliste.Rows[e.RowIndex];

                
                txtmatricule.Text = row.Cells["MATRICULE"].Value.ToString();
                txtmarque.Text = row.Cells["Column1"].Value.ToString();
                txtmodele.Text = row.Cells["Column2"].Value.ToString();
                txtannee.Text = row.Cells["Column3"].Value.ToString();
                txtprix.Text = row.Cells["Column4"].Value.ToString();
                string imagePath = row.Cells["image_path"].Value.ToString();

                if (File.Exists(imagePath))
                {
                    plimage.BackgroundImage = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("L'image n'existe pas : " + imagePath);
                    plimage.BackgroundImage = null; // Par sécurité
                }


               
                if (row.Cells["Column5"] != null)
                {
                    int idVoiture = Convert.ToInt32(row.Cells["Id"].Value);
                   
                }
            }
        }

    }
}
