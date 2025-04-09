namespace InventoryApp
{
    partial class CardControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lbtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbdescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            lbprice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbstock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbcategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbsupply = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbid = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox2
            // 
            PictureBox2.ImageRotate = 0F;
            PictureBox2.Location = new Point(19, 34);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges1;
            PictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            PictureBox2.Size = new Size(104, 106);
            PictureBox2.TabIndex = 0;
            PictureBox2.TabStop = false;
            PictureBox2.Click += guna2CirclePictureBox1_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(283, 13);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Size = new Size(84, 33);
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // lbtitle
            // 
            lbtitle.BackColor = Color.Transparent;
            lbtitle.Location = new Point(146, 57);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(26, 17);
            lbtitle.TabIndex = 2;
            lbtitle.Text = "Titre";
            lbtitle.Click += guna2HtmlLabel1_Click;
            // 
            // lbdescription
            // 
            lbdescription.BackColor = Color.Transparent;
            lbdescription.Location = new Point(146, 80);
            lbdescription.Name = "lbdescription";
            lbdescription.Size = new Size(63, 17);
            lbdescription.TabIndex = 3;
            lbdescription.Text = "Description";
            lbdescription.Click += guna2HtmlLabel2_Click;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { modifierToolStripMenuItem, supprimerToolStripMenuItem });
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(129, 22);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(129, 22);
            supprimerToolStripMenuItem.Text = "Supprimer";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // lbprice
            // 
            lbprice.BackColor = Color.Transparent;
            lbprice.Location = new Point(304, 161);
            lbprice.Name = "lbprice";
            lbprice.Size = new Size(23, 17);
            lbprice.TabIndex = 4;
            lbprice.Text = "Prix";
            // 
            // lbstock
            // 
            lbstock.BackColor = Color.Transparent;
            lbstock.Location = new Point(304, 138);
            lbstock.Name = "lbstock";
            lbstock.Size = new Size(32, 17);
            lbstock.TabIndex = 5;
            lbstock.Text = "Stock";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(257, 138);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(35, 17);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Stock:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(264, 161);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(26, 17);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "Prix:";
            // 
            // lbcategory
            // 
            lbcategory.BackColor = Color.Transparent;
            lbcategory.Location = new Point(96, 146);
            lbcategory.Name = "lbcategory";
            lbcategory.Size = new Size(54, 17);
            lbcategory.TabIndex = 8;
            lbcategory.Text = "Catégorie";
            // 
            // lbsupply
            // 
            lbsupply.BackColor = Color.Transparent;
            lbsupply.Location = new Point(96, 164);
            lbsupply.Name = "lbsupply";
            lbsupply.Size = new Size(64, 17);
            lbsupply.TabIndex = 9;
            lbsupply.Text = "Fournisseur";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Location = new Point(19, 146);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(57, 17);
            guna2HtmlLabel3.TabIndex = 10;
            guna2HtmlLabel3.Text = "Catégorie:";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Location = new Point(19, 164);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(67, 17);
            guna2HtmlLabel4.TabIndex = 11;
            guna2HtmlLabel4.Text = "Fournisseur:";
            // 
            // lbid
            // 
            lbid.BackColor = SystemColors.Control;
            lbid.ForeColor = SystemColors.Control;
            lbid.Location = new Point(134, 13);
            lbid.Name = "lbid";
            lbid.Size = new Size(26, 17);
            lbid.TabIndex = 12;
            lbid.Text = "Titre";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // CardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbid);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(lbsupply);
            Controls.Add(lbcategory);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(lbstock);
            Controls.Add(lbprice);
            Controls.Add(lbdescription);
            Controls.Add(lbtitle);
            Controls.Add(guna2PictureBox1);
            Controls.Add(PictureBox2);
            Name = "CardControl";
            Size = new Size(380, 181);
            Load += CardControl_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2ContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbdescription;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbprice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbstock;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbcategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbsupply;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbid;
        private System.Windows.Forms.Timer timer1;
    }
}
