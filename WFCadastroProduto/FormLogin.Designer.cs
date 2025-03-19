namespace WFCadastroProduto
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btn_acessar = new Button();
            lbl_login = new Label();
            txt_login = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            chb_motrarsenha = new CheckBox();
            SuspendLayout();
            // 
            // btn_acessar
            // 
            btn_acessar.Location = new Point(118, 190);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(75, 23);
            btn_acessar.TabIndex = 0;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = true;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Location = new Point(22, 33);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(40, 15);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "Login:";
            // 
            // txt_login
            // 
            txt_login.Location = new Point(22, 51);
            txt_login.Name = "txt_login";
            txt_login.PlaceholderText = "Informe o seu usuario";
            txt_login.Size = new Size(171, 23);
            txt_login.TabIndex = 2;
            txt_login.Tag = "";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(22, 121);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.PlaceholderText = "Informe a sua senha";
            txt_senha.Size = new Size(171, 23);
            txt_senha.TabIndex = 4;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(22, 103);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha:";
            // 
            // chb_motrarsenha
            // 
            chb_motrarsenha.AutoSize = true;
            chb_motrarsenha.Location = new Point(22, 150);
            chb_motrarsenha.Name = "chb_motrarsenha";
            chb_motrarsenha.Size = new Size(102, 19);
            chb_motrarsenha.TabIndex = 5;
            chb_motrarsenha.Text = "Mostrar Senha";
            chb_motrarsenha.UseVisualStyleBackColor = true;
            chb_motrarsenha.CheckedChanged += chb_motrarsenha_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            ClientSize = new Size(224, 238);
            Controls.Add(chb_motrarsenha);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_login);
            Controls.Add(lbl_login);
            Controls.Add(btn_acessar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Acessar";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_acessar;
        private Label lbl_login;
        private TextBox txt_login;
        private TextBox txt_senha;
        private Label lbl_senha;
        private CheckBox chb_motrarsenha;
    }
}
