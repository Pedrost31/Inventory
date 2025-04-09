namespace InventoryApp
{
    partial class InventoryApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryApp));
            label1 = new Label();
            imageList1 = new ImageList(components);
            PasswordBoxSignIn = new TextBox();
            EmailBoxSignIn = new TextBox();
            Email = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            connect_button = new Button();
            ResetPasswordSignIn = new LinkLabel();
            RegisterLinkSignIn = new LinkLabel();
            linkLabel3 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(675, 17);
            label1.Name = "label1";
            label1.Size = new Size(556, 174);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Black;
            imageList1.Images.SetKeyName(0, "dropbox.png");
            // 
            // PasswordBoxSignIn
            // 
            PasswordBoxSignIn.Location = new Point(675, 271);
            PasswordBoxSignIn.Margin = new Padding(3, 2, 3, 2);
            PasswordBoxSignIn.Name = "PasswordBoxSignIn";
            PasswordBoxSignIn.PasswordChar = '*';
            PasswordBoxSignIn.Size = new Size(276, 23);
            PasswordBoxSignIn.TabIndex = 3;
            // 
            // EmailBoxSignIn
            // 
            EmailBoxSignIn.Location = new Point(675, 196);
            EmailBoxSignIn.Margin = new Padding(3, 2, 3, 2);
            EmailBoxSignIn.Name = "EmailBoxSignIn";
            EmailBoxSignIn.Size = new Size(276, 23);
            EmailBoxSignIn.TabIndex = 4;
            EmailBoxSignIn.Text = "Enter your email";
            EmailBoxSignIn.TextChanged += textBox1_TextChanged_1;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.ForeColor = SystemColors.ButtonHighlight;
            Email.Location = new Point(675, 167);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 5;
            Email.Text = "Email";
            Email.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(675, 246);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, -30);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 517);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 28F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(38, 117);
            label4.Name = "label4";
            label4.Size = new Size(412, 47);
            label4.TabIndex = 1;
            label4.Text = "Inventory Manager";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 28F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(32, 64);
            label2.Name = "label2";
            label2.Size = new Size(261, 47);
            label2.TabIndex = 0;
            label2.Text = "Welcome to";
            label2.Click += label2_Click_1;
            // 
            // connect_button
            // 
            connect_button.Location = new Point(869, 415);
            connect_button.Margin = new Padding(3, 2, 3, 2);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(82, 22);
            connect_button.TabIndex = 8;
            connect_button.Text = "Connect";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += button1_Click;
            // 
            // ResetPasswordSignIn
            // 
            ResetPasswordSignIn.AutoSize = true;
            ResetPasswordSignIn.Location = new Point(843, 294);
            ResetPasswordSignIn.Name = "ResetPasswordSignIn";
            ResetPasswordSignIn.Size = new Size(96, 15);
            ResetPasswordSignIn.TabIndex = 9;
            ResetPasswordSignIn.TabStop = true;
            ResetPasswordSignIn.Text = "Reset password ?";
            // 
            // RegisterLinkSignIn
            // 
            RegisterLinkSignIn.AutoSize = true;
            RegisterLinkSignIn.Location = new Point(786, 294);
            RegisterLinkSignIn.Margin = new Padding(2, 0, 2, 0);
            RegisterLinkSignIn.Name = "RegisterLinkSignIn";
            RegisterLinkSignIn.Size = new Size(49, 15);
            RegisterLinkSignIn.TabIndex = 10;
            RegisterLinkSignIn.TabStop = true;
            RegisterLinkSignIn.Text = "Register";
            RegisterLinkSignIn.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(923, 373);
            linkLabel3.Margin = new Padding(2, 0, 2, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(0, 15);
            linkLabel3.TabIndex = 11;
            // 
            // InventoryApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1018, 450);
            Controls.Add(linkLabel3);
            Controls.Add(RegisterLinkSignIn);
            Controls.Add(ResetPasswordSignIn);
            Controls.Add(connect_button);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(EmailBoxSignIn);
            Controls.Add(PasswordBoxSignIn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryApp";
            Text = "InventoryApp";
            Load += InventoryApp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageList1;
        private TextBox PasswordBoxSignIn;
        private TextBox EmailBoxSignIn;
        private Label Email;
        private Label label3;
        private Panel panel1;
        private Button connect_button;
        private LinkLabel ResetPasswordSignIn;
        private Label label2;
        private Label label4;
        private LinkLabel RegisterLinkSignIn;
        private LinkLabel linkLabel3;
    }
}
