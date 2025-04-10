namespace InventoryApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            flowLayoutPanel1 = new FlowLayoutPanel();
            txsearch = new Guna.UI2.WinForms.Guna2TextBox();
            AddCard = new MaterialSkin.Controls.MaterialFloatingActionButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            timer1 = new System.Windows.Forms.Timer(components);
            deleteTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(20, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1207, 562);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // txsearch
            // 
            txsearch.BorderRadius = 15;
            txsearch.CustomizableEdges = customizableEdges1;
            txsearch.DefaultText = "";
            txsearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txsearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txsearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txsearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txsearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txsearch.Font = new Font("Segoe UI", 9F);
            txsearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txsearch.Location = new Point(20, 82);
            txsearch.Name = "txsearch";
            txsearch.PlaceholderText = "Search";
            txsearch.SelectedText = "";
            txsearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txsearch.Size = new Size(200, 36);
            txsearch.TabIndex = 1;
            txsearch.TextChanged += txsearch_TextChanged;
            txsearch.KeyPress += txsearch_Key;
            // 
            // AddCard
            // 
            AddCard.Depth = 0;
            AddCard.Icon = null;
            AddCard.Image = (Image)resources.GetObject("AddCard.Image");
            AddCard.Location = new Point(1171, 692);
            AddCard.MouseState = MaterialSkin.MouseState.HOVER;
            AddCard.Name = "AddCard";
            AddCard.Size = new Size(56, 56);
            AddCard.TabIndex = 2;
            AddCard.Text = "materialFloatingActionButton1";
            AddCard.UseVisualStyleBackColor = true;
            AddCard.Click += AddCard_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // deleteTimer
            // 
            deleteTimer.Enabled = true;
            deleteTimer.Tick += deleteTimer_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 754);
            Controls.Add(AddCard);
            Controls.Add(txsearch);
            Controls.Add(flowLayoutPanel1);
            Name = "Form4";
            Text = "Inventaire ";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txsearch;
        private MaterialSkin.Controls.MaterialFloatingActionButton AddCard;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer deleteTimer;
    }
}