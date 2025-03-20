namespace WFCadastroProduto
{
    partial class FormCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            txt_senha = new TextBox();
            lbl_senha = new Label();
            txt_novologin = new TextBox();
            lbl_novologin = new Label();
            btn_cadastrarusuario = new Button();
            txt_repitaasenha = new TextBox();
            lbl_repitaasenha = new Label();
            chk_mostrarsenha = new CheckBox();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(45, 95);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Informe a senha";
            txt_senha.Size = new Size(171, 23);
            txt_senha.TabIndex = 11;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(45, 77);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 10;
            lbl_senha.Text = "Senha:";
            // 
            // txt_novologin
            // 
            txt_novologin.Location = new Point(45, 39);
            txt_novologin.Name = "txt_novologin";
            txt_novologin.PlaceholderText = "Informe um novo usuario";
            txt_novologin.Size = new Size(171, 23);
            txt_novologin.TabIndex = 9;
            txt_novologin.Tag = "";
            // 
            // lbl_novologin
            // 
            lbl_novologin.AutoSize = true;
            lbl_novologin.Location = new Point(45, 21);
            lbl_novologin.Name = "lbl_novologin";
            lbl_novologin.Size = new Size(72, 15);
            lbl_novologin.TabIndex = 8;
            lbl_novologin.Text = "Novo Login:";
            // 
            // btn_cadastrarusuario
            // 
            btn_cadastrarusuario.Location = new Point(45, 225);
            btn_cadastrarusuario.Name = "btn_cadastrarusuario";
            btn_cadastrarusuario.Size = new Size(171, 23);
            btn_cadastrarusuario.TabIndex = 7;
            btn_cadastrarusuario.Text = "Cadatrar ";
            btn_cadastrarusuario.UseVisualStyleBackColor = true;
            btn_cadastrarusuario.Click += btn_cadastraracessar_Click;
            // 
            // txt_repitaasenha
            // 
            txt_repitaasenha.Location = new Point(45, 159);
            txt_repitaasenha.Name = "txt_repitaasenha";
            txt_repitaasenha.PasswordChar = '*';
            txt_repitaasenha.PlaceholderText = "Repita a senha";
            txt_repitaasenha.Size = new Size(171, 23);
            txt_repitaasenha.TabIndex = 14;
            // 
            // lbl_repitaasenha
            // 
            lbl_repitaasenha.AutoSize = true;
            lbl_repitaasenha.Location = new Point(45, 141);
            lbl_repitaasenha.Name = "lbl_repitaasenha";
            lbl_repitaasenha.Size = new Size(87, 15);
            lbl_repitaasenha.TabIndex = 13;
            lbl_repitaasenha.Text = "Repita a Senha:";
            // 
            // chk_mostrarsenha
            // 
            chk_mostrarsenha.AutoSize = true;
            chk_mostrarsenha.Location = new Point(45, 188);
            chk_mostrarsenha.Name = "chk_mostrarsenha";
            chk_mostrarsenha.Size = new Size(102, 19);
            chk_mostrarsenha.TabIndex = 15;
            chk_mostrarsenha.Text = "Mostrar Senha";
            chk_mostrarsenha.UseVisualStyleBackColor = true;
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            ClientSize = new Size(268, 270);
            Controls.Add(chk_mostrarsenha);
            Controls.Add(txt_repitaasenha);
            Controls.Add(lbl_repitaasenha);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_novologin);
            Controls.Add(lbl_novologin);
            Controls.Add(btn_cadastrarusuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Novo Usuario";
            Load += FormCadastroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_senha;
        private Label lbl_senha;
        private TextBox txt_novologin;
        private Label lbl_novologin;
        private Button btn_cadastrarusuario;
        private TextBox txt_repitaasenha;
        private Label lbl_repitaasenha;
        private CheckBox chk_mostrarsenha;
    }
}