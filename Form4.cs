using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Models;
using InventoryApp.Repositories;
using MaterialSkin;
using MaterialSkin.Controls;

namespace InventoryApp
{
    public partial class Form4 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public Form4()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            initDetails();
            loadCards();
        }
        int i;
        private void loadCards()
        {
            // Crée une instance de ProductsRepository pour récupérer la liste des produits
            ProductsRepository productsRepository = new ProductsRepository();

            // Récupère la liste des produits depuis la base de données
            List<Products> productList = productsRepository.GetAllProducts();

            // Parcours chaque produit dans la liste récupérée
            foreach (Products product in productList)
            {
                i++;  // Incrémente i à chaque itération

                // Crée un nouveau contrôle CardControl pour chaque produit
                CardControl card = new CardControl();

                // Affiche les détails du produit dans le contrôle CardControl
                card.CardDetails(product);

                // Ajoute le contrôle CardControl dans le conteneur (par exemple, un Panel ou FlowLayoutPanel)
                flowLayoutPanel1.Controls.Add(card);

                // Tu peux éventuellement utiliser i pour effectuer des actions spécifiques
                // Par exemple, utiliser i pour ajuster un style, affecter des attributs ou des événements
            }
        }


        private void initDetails()
        {
            // Crée une instance de ProductsRepository pour récupérer la liste des produits
            ProductsRepository productsRepository = new ProductsRepository();

            // Récupère la liste des produits
            List<Products> productList = productsRepository.GetAllProducts();
        }


        private void AddCard_Click(object sender, EventArgs e)
        {
            Form background = new Form(); try
            {
                using (Form5 frm = new Form5())
                {
                    background.StartPosition = FormStartPosition.Manual;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = .50d;
                    background.BackColor = Color.Black;
                    background.WindowState = FormWindowState.Maximized;
                    background.Location = this.Location;
                    background.ShowInTaskbar = false;
                    background.Show();
                    frm.Owner = background;
                    frm.ShowDialog();
                    background.Dispose();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                background.Dispose();
            }

        }

        private void cardControl1_Load(object sender, EventArgs e)
        {

        }

        private void cardControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form5.refresh == true)
            {
                CardControl card = new CardControl();
                flowLayoutPanel1.Controls.Add(card);
                Form5.refresh = false;

            }
        }

        private void deleteTimer_Tick(object sender, EventArgs e)
        {
            if (CardControl.isDeleted == true)
            {
                flowLayoutPanel1.Controls.Clear();
                loadCards();
                initDetails();
                CardControl.isDeleted = false;
            }
        }
    }
}
