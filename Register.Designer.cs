
namespace InventoryApp
{
    partial class Register
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
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            ConnectLikeRegister = new LinkLabel();
            ResetPassword = new LinkLabel();
            Create_button = new Button();
            label1 = new Label();
            label5 = new Label();
            EmailBox = new TextBox();
            label3 = new Label();
            NameBox = new TextBox();
            PasswordBox = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, -3);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 483);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 28F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(40, 85);
            label4.Name = "label4";
            label4.Size = new Size(412, 47);
            label4.TabIndex = 3;
            label4.Text = "Inventory Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 28F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 31);
            label2.Name = "label2";
            label2.Size = new Size(261, 47);
            label2.TabIndex = 2;
            label2.Text = "Welcome to";
            // 
            // ConnectLikeRegister
            // 
            ConnectLikeRegister.AutoSize = true;
            ConnectLikeRegister.Location = new Point(769, 305);
            ConnectLikeRegister.Margin = new Padding(2, 0, 2, 0);
            ConnectLikeRegister.Name = "ConnectLikeRegister";
            ConnectLikeRegister.Size = new Size(43, 15);
            ConnectLikeRegister.TabIndex = 18;
            ConnectLikeRegister.TabStop = true;
            ConnectLikeRegister.Text = "Sign In";
            ConnectLikeRegister.LinkClicked += ConnectLikeRegister_LinkClicked;
            // 
            // ResetPassword
            // 
            ResetPassword.AutoSize = true;
            ResetPassword.Location = new Point(827, 305);
            ResetPassword.Name = "ResetPassword";
            ResetPassword.Size = new Size(96, 15);
            ResetPassword.TabIndex = 17;
            ResetPassword.TabStop = true;
            ResetPassword.Text = "Reset password ?";
            ResetPassword.LinkClicked += ResetPassword_LinkClicked;
            // 
            // Create_button
            // 
            Create_button.Location = new Point(803, 431);
            Create_button.Margin = new Padding(3, 2, 3, 2);
            Create_button.Name = "Create_button";
            Create_button.Size = new Size(131, 22);
            Create_button.TabIndex = 16;
            Create_button.Text = "Create account";
            Create_button.UseVisualStyleBackColor = true;
            Create_button.Click += Create_button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(659, 28);
            label1.Name = "label1";
            label1.Size = new Size(696, 229);
            label1.TabIndex = 11;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(657, 161);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 20;
            label5.Text = "Name";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(659, 230);
            EmailBox.Margin = new Padding(3, 2, 3, 2);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(276, 23);
            EmailBox.TabIndex = 21;
            EmailBox.TextChanged += EmailBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(659, 207);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 22;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(657, 185);
            NameBox.Margin = new Padding(3, 2, 3, 2);
            NameBox.Name = "NameBox";
            NameBox.PasswordChar = '*';
            NameBox.Size = new Size(276, 23);
            NameBox.TabIndex = 23;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(657, 279);
            PasswordBox.Margin = new Padding(3, 2, 3, 2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(276, 23);
            PasswordBox.TabIndex = 24;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(659, 257);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 25;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1158, 505);
            Controls.Add(label6);
            Controls.Add(PasswordBox);
            Controls.Add(NameBox);
            Controls.Add(label3);
            Controls.Add(EmailBox);
            Controls.Add(label5);
            Controls.Add(ConnectLikeRegister);
            Controls.Add(panel1);
            Controls.Add(ResetPassword);
            Controls.Add(label1);
            Controls.Add(Create_button);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PasswordBoxRegister_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EmailBoxRegister_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private LinkLabel ConnectLikeRegister;
        private LinkLabel ResetPassword;
        private Button Create_button;
        private Label label1;
        private Label label5;
        private TextBox EmailBox;
        private Label label3;
        private TextBox NameBox;
        private TextBox PasswordBox;
        private Label label6;
    }
}