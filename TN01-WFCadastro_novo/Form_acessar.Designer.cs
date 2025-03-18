namespace TN01_WFCadastro_novo
{
    partial class Form_acessar
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
            btn_acessar = new Button();
            lbl_login = new Label();
            txt_login = new TextBox();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            SuspendLayout();
            // 
            // btn_acessar
            // 
            btn_acessar.Location = new Point(100, 178);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(100, 23);
            btn_acessar.TabIndex = 0;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = true;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Location = new Point(100, 36);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(40, 15);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "Login:";
            // 
            // txt_login
            // 
            txt_login.Location = new Point(100, 54);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(100, 23);
            txt_login.TabIndex = 2;
            txt_login.TextChanged += txt_login_TextChanged;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(100, 112);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 4;
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(100, 94);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha:";
            // 
            // Form_acessar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_login);
            Controls.Add(lbl_login);
            Controls.Add(btn_acessar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_acessar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acessar";
            Load += Form_acessar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_acessar;
        private Label lbl_login;
        private TextBox txt_login;
        private TextBox txt_senha;
        private Label lbl_senha;
    }
}
