using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using InventoryApp.Repositories;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class Form5 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public const string CLOUDNAME = "dwa1j5cky";
        public const string API_KEY = "238262973692649";
        public const string API_SECRET = "sAcl7BP8IBO7LbZ7m6gRUJnxabw";
        public Cloudinary cloudinary;
        string imagePath, imageLink;
        public Form5()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
        }
        private void Form5_Load(object sender, EventArgs e)
        {
          

                if (CardControl.view == true)
                {
                    // Ajouter un message de débogage avant d'appeler getDetail
                    System.Diagnostics.Debug.WriteLine("Appel de getDetail");
                    getDetail();
                    Save.Text = "Modifier";
                update = true;
                }
                else
                {
                    Save.Text = "Enregistrer";
                update=false;
            }
            }
          
    


        private void cloudinaryStorage()
        {
            Account account = new Account(CLOUDNAME, API_KEY, API_SECRET);
            cloudinary = new Cloudinary(account);
            uploadImage(imagePath);
        }
        public void uploadImage(string path)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(path),

            };
            var res = cloudinary.Upload(uploadParams);
            imageLink = res.Uri.ToString();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "Image | *.jpg; *.png; *.jpeg";
            DialogResult res = dig.ShowDialog();
            if (res == DialogResult.OK)
            {
                Image.Image = new Bitmap(dig.FileName);
                imagePath = dig.FileName;

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            cloudinaryStorage();
        }
        public static bool refresh = false;
        public static bool isUpdate = false;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(update == false)
            {
                ProductsRepository repo = new ProductsRepository();
                Products product = new Products();

                product.nom = txtitle.Text;
                product.description = txtdescription.Text;
                product.image_link = imageLink;
                product.categorie = txtcategory.Text;
                product.fournisseur = txtsupply.Text;
                product.prix = Convert.ToDouble(txtprice.Text);
                product.stock = Convert.ToInt32(txtstock.Text);
                product.seuil_alerte = Convert.ToInt32(txtalert.Text);
                repo.CreateProduct(product);
                refresh = true;
                MessageBox.Show("Produit ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Ici vous mettez à jour un produit existant
                ProductsRepository repo = new ProductsRepository();
                Products product = new Products();

                // Assurez-vous que vous avez bien les données du produit pour la mise à jour
                product.id = Convert.ToInt32(CardControl.public_id);  // ID du produit à mettre à jour
                product.nom = txtitle.Text;
                product.description = txtdescription.Text;
                product.image_link = imageLink; // ou vous pouvez garder l'ancienne image si elle n'a pas changé
                product.categorie = txtcategory.Text;
                product.fournisseur = txtsupply.Text;
                product.prix = Convert.ToDouble(txtprice.Text);
                product.stock = Convert.ToInt32(txtstock.Text);
                product.seuil_alerte = Convert.ToInt32(txtalert.Text);

                // Appel de la méthode UpdateProduct pour mettre à jour un produit
                repo.UpdateProduct(product);

                isUpdate = true;
                MessageBox.Show("Produit mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
           


        }

        private void Save_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        bool update = false;
        private void getDetail()
        {
            try
            {
                // Étape 1: Afficher la valeur de public_id avant de la convertir
                System.Diagnostics.Debug.WriteLine("public_id avant conversion : " + CardControl.public_id);

                // Conversion de string en int
                int id = Convert.ToInt32(CardControl.public_id);

                // Afficher l'id converti pour vérifier si la conversion est correcte
                System.Diagnostics.Debug.WriteLine("id après conversion : " + id);

                // Étape 2: Créer l'instance de ProductsRepository et récupérer le produit
                ProductsRepository productsRepository = new ProductsRepository();
                Products product = productsRepository.GetProductById(id);

                // Étape 3: Vérifier si le produit est récupéré ou si c'est null
                if (product != null)
                {
                    System.Diagnostics.Debug.WriteLine("Produit trouvé : " + product.nom);

                    // Afficher les valeurs récupérées pour vérifier que tout est correct
                    txtitle.Text = product.nom;
                    txtdescription.Text = product.description;
                    txtcategory.Text = product.categorie;
                    txtsupply.Text = product.fournisseur;
                    txtprice.Text = product.prix.ToString("C");
                    txtstock.Text = product.stock.ToString();
                    txtalert.Text = product.seuil_alerte.ToString();
                    Image.ImageLocation = product.image_link;
                }
                else
                {
                    // Si le produit est null, afficher un message dans le Debug
                    System.Diagnostics.Debug.WriteLine("Aucun produit trouvé avec l'ID : " + id);
                }
            }
            catch (Exception ex)
            {
                // Si une erreur se produit, afficher l'exception dans la console de débogage
                System.Diagnostics.Debug.WriteLine("Erreur dans getDetail : " + ex.Message);
            }
        }

    }
}
