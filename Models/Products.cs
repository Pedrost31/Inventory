using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Models
{
    public class Products
        {
            public int id;
            public string nom = "";
            public string description = "";
            public int stock;
            public double prix;
            public int seuil_alerte;
        public string categorie = "";
        public string fournisseur = "";
        public string image_link = "";

    }

}
