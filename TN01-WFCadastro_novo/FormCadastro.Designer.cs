namespace TN01_WFCadastro_novo
{
    partial class FormCadastro
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
            lbl_login = new Label();
            txt_login = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            txt_confirmasenha = new TextBox();
            lbl_confimasenha = new Label();
            btn_cadastrar = new Button();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Location = new Point(187, 52);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(37, 15);
            lbl_login.TabIndex = 0;
            lbl_login.Text = "Login";
            lbl_login.Click += lbl_login_Click;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(40, 52);
            txt_login.Name = "txt_login";
            txt_login.PlaceholderText = "digite o usuario";
            txt_login.Size = new Size(141, 23);
            txt_login.TabIndex = 1;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(40, 105);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "digite a senha";
            txt_senha.Size = new Size(141, 23);
            txt_senha.TabIndex = 3;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(187, 105);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha";
            // 
            // txt_confirmasenha
            // 
            txt_confirmasenha.Location = new Point(40, 162);
            txt_confirmasenha.Name = "txt_confirmasenha";
            txt_confirmasenha.PasswordChar = '*';
            txt_confirmasenha.PlaceholderText = "repita a senha";
            txt_confirmasenha.Size = new Size(141, 23);
            txt_confirmasenha.TabIndex = 5;
            // 
            // lbl_confimasenha
            // 
            lbl_confimasenha.AutoSize = true;
            lbl_confimasenha.Location = new Point(187, 162);
            lbl_confimasenha.Name = "lbl_confimasenha";
            lbl_confimasenha.Size = new Size(92, 15);
            lbl_confimasenha.TabIndex = 4;
            lbl_confimasenha.Text = "Confirma Senha";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(204, 228);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 286);
            Controls.Add(btn_cadastrar);
            Controls.Add(txt_confirmasenha);
            Controls.Add(lbl_confimasenha);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_login);
            Controls.Add(lbl_login);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Usuario";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_login;
        private TextBox txt_login;
        private TextBox txt_senha;
        private Label lbl_senha;
        private TextBox txt_confirmasenha;
        private Label lbl_confimasenha;
        private Button btn_cadastrar;
    }
}