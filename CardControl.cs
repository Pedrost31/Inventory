using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Models;
using InventoryApp.Repositories;



namespace InventoryApp
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {

            InitializeComponent();
        }
        public void CardDetails(Products p)
        {
            lbtitle.Text = p.nom;  // lbtitle est un contrôle Label, donc on affecte sa propriété Text
            lbdescription.Text = p.description;  // lbdescription est aussi un contrôle Label
            lbstock.Text = p.stock.ToString();  // lbstock est un contrôle Label, donc on convertit le stock en chaîne
            lbprice.Text = p.prix.ToString("C2");
            lbcategory.Text = p.categorie;  // lbcategory est un contrôle Label
            lbsupply.Text = p.fournisseur;  // lbsupply est un contrôle Label
            PictureBox2.ImageLocation = p.image_link;  // PictureBox2 est un contrôle d'image
            lbid.Text = p.id.ToString(); // lbid est un contrôle Label, donc on convertit l'id en chaîne
        }
        public void displayNew()
        {
            // Crée une instance de ProductsRepository pour récupérer le dernier produit inséré
            ProductsRepository productsRepository = new ProductsRepository();

            // Récupère le dernier produit inséré
            Products lastProduct = productsRepository.GetLastInsertedProduct();

            // Affiche les détails du dernier produit dans les contrôles
            lbtitle.Text = lastProduct?.nom; // Si lastProduct est null, afficher "Aucun produit trouvé"
            lbdescription.Text = lastProduct?.description; // Si lastProduct est null, laisser vide
            lbstock.Text = lastProduct?.stock.ToString(); // Si lastProduct est null, laisser vide
            lbsupply.Text = lastProduct?.fournisseur; // Si lastProduct est null, laisser vide
            lbcategory.Text = lastProduct?.categorie; // Si lastProduct est null, laisser vide
            lbprice.Text = lastProduct?.prix.ToString("C2"); // Si lastProduct est null, laisser vide
            PictureBox2.ImageLocation = lastProduct?.image_link; // Si lastProduct est null, laisser l'ImageLocation vide
            lbid.Text = lastProduct?.id.ToString(); // Si lastProduct est null, laisser vide    
        }

        private void CardControl_Load(object sender, EventArgs e)
        {
            if (Form5.refresh == true)
            {
                displayNew();
            }

        }

        public void RefreshProduct(int id)
        {

        }

        private void LoadProduct(int id)
        {

        }


        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void previousButton_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

            guna2ContextMenuStrip1.Show(guna2PictureBox1, new Point(0, guna2PictureBox1.Height));

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        public static bool view = false;
        public static string public_id;
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            view = true;
            public_id = lbid.Text;
            Form5 form = new Form5();
            form.ShowDialog();


        }
        public static bool isDeleted = false;
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDeleted = true;
            ProductsRepository repo = new ProductsRepository();
            int productId = Convert.ToInt32(lbid.Text); // Convertir lbid.Text en entier
            repo.DeleteProduct(productId); // Supprimer le produit avec cet ID


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Vérifiez si la mise à jour a été effectuée dans Form5
            if (Form5.isUpdate == true)
            {
                // Utilisez l'ID du produit que vous souhaitez actualiser
                int productId = Convert.ToInt32(lbid.Text);  // Assurez-vous d'avoir l'ID du produit (peut-être depuis un label ou autre contrôle)

                // Créez une instance de ProductsRepository pour récupérer le produit mis à jour
                ProductsRepository repo = new ProductsRepository();
                Products updatedProduct = repo.GetProductById(productId);

                if (updatedProduct != null)
                {
                    // Mettre à jour les contrôles avec les nouvelles informations
                    lbtitle.Text = updatedProduct.nom;
                    lbdescription.Text = updatedProduct.description;
                    lbstock.Text = updatedProduct.stock.ToString();
                    lbprice.Text = updatedProduct.prix.ToString("C2");
                    lbcategory.Text = updatedProduct.categorie;
                    lbsupply.Text = updatedProduct.fournisseur;
                    PictureBox2.ImageLocation = updatedProduct.image_link;
                    lbid.Text = updatedProduct.id.ToString();
                }
                else
                {
                    MessageBox.Show("Produit non trouvé !");
                }

                // Réinitialisez isUpdate pour éviter de refaire l'actualisation plusieurs fois
                Form5.isUpdate = false;
            }
        }

    }
}

