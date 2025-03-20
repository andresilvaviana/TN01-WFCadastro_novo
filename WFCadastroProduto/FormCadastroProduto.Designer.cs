namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lbl_cadastro = new Label();
            lbl_categoria = new Label();
            lbl_nomeproduto = new Label();
            lbl_preco = new Label();
            lbl_datavencimento = new Label();
            lbl_observacao = new Label();
            cbx_categoria = new ComboBox();
            dtp_datavencimento = new DateTimePicker();
            nud_preco = new NumericUpDown();
            rtb_observacao = new RichTextBox();
            txt_codigo = new TextBox();
            txt_nomeproduto = new TextBox();
            btn_salva = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_preco).BeginInit();
            SuspendLayout();
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Location = new Point(12, 29);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(46, 15);
            lbl_cadastro.TabIndex = 0;
            lbl_cadastro.Text = "Codigo";
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Location = new Point(128, 29);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(58, 15);
            lbl_categoria.TabIndex = 1;
            lbl_categoria.Text = "Categoria";
            // 
            // lbl_nomeproduto
            // 
            lbl_nomeproduto.AutoSize = true;
            lbl_nomeproduto.Location = new Point(12, 103);
            lbl_nomeproduto.Name = "lbl_nomeproduto";
            lbl_nomeproduto.Size = new Size(103, 15);
            lbl_nomeproduto.TabIndex = 2;
            lbl_nomeproduto.Text = "Nome do Produto";
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Location = new Point(12, 171);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(37, 15);
            lbl_preco.TabIndex = 3;
            lbl_preco.Text = "Preço";
            // 
            // lbl_datavencimento
            // 
            lbl_datavencimento.AutoSize = true;
            lbl_datavencimento.Location = new Point(184, 171);
            lbl_datavencimento.Name = "lbl_datavencimento";
            lbl_datavencimento.Size = new Size(113, 15);
            lbl_datavencimento.TabIndex = 4;
            lbl_datavencimento.Text = "Data de Vencimento";
            // 
            // lbl_observacao
            // 
            lbl_observacao.AutoSize = true;
            lbl_observacao.Location = new Point(12, 251);
            lbl_observacao.Name = "lbl_observacao";
            lbl_observacao.Size = new Size(69, 15);
            lbl_observacao.TabIndex = 5;
            lbl_observacao.Text = "Observação";
            // 
            // cbx_categoria
            // 
            cbx_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Items.AddRange(new object[] { "Açougue", "Frios e laticínios", "Adega e bebidas", "Higiene e limpeza", "Hortifruti", "Mercearia", "Padaria", "Enlatados", "Cereais" });
            cbx_categoria.Location = new Point(128, 47);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(169, 23);
            cbx_categoria.TabIndex = 2;
            cbx_categoria.SelectedIndexChanged += cbx_categoria_SelectedIndexChanged;
            // 
            // dtp_datavencimento
            // 
            dtp_datavencimento.Format = DateTimePickerFormat.Custom;
            dtp_datavencimento.Location = new Point(184, 189);
            dtp_datavencimento.Name = "dtp_datavencimento";
            dtp_datavencimento.Size = new Size(113, 23);
            dtp_datavencimento.TabIndex = 5;
            // 
            // nud_preco
            // 
            nud_preco.DecimalPlaces = 2;
            nud_preco.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nud_preco.Location = new Point(12, 189);
            nud_preco.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nud_preco.Name = "nud_preco";
            nud_preco.Size = new Size(140, 23);
            nud_preco.TabIndex = 4;
            // 
            // rtb_observacao
            // 
            rtb_observacao.Location = new Point(12, 269);
            rtb_observacao.Name = "rtb_observacao";
            rtb_observacao.Size = new Size(285, 96);
            rtb_observacao.TabIndex = 6;
            rtb_observacao.Text = "";
            // 
            // txt_codigo
            // 
            txt_codigo.BorderStyle = BorderStyle.FixedSingle;
            txt_codigo.Enabled = false;
            txt_codigo.Location = new Point(12, 47);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(103, 23);
            txt_codigo.TabIndex = 1;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
            // 
            // txt_nomeproduto
            // 
            txt_nomeproduto.Location = new Point(12, 121);
            txt_nomeproduto.Name = "txt_nomeproduto";
            txt_nomeproduto.Size = new Size(285, 23);
            txt_nomeproduto.TabIndex = 3;
            // 
            // btn_salva
            // 
            btn_salva.FlatStyle = FlatStyle.Flat;
            btn_salva.Font = new Font("Script MT Bold", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_salva.ForeColor = SystemColors.ActiveCaptionText;
            btn_salva.Location = new Point(12, 385);
            btn_salva.Name = "btn_salva";
            btn_salva.Size = new Size(285, 41);
            btn_salva.TabIndex = 7;
            btn_salva.Text = "Salvar";
            btn_salva.TextAlign = ContentAlignment.TopCenter;
            btn_salva.UseVisualStyleBackColor = true;
            btn_salva.Click += btn_salva_Click;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 228, 201);
            ClientSize = new Size(319, 450);
            Controls.Add(btn_salva);
            Controls.Add(txt_nomeproduto);
            Controls.Add(txt_codigo);
            Controls.Add(rtb_observacao);
            Controls.Add(nud_preco);
            Controls.Add(dtp_datavencimento);
            Controls.Add(cbx_categoria);
            Controls.Add(lbl_observacao);
            Controls.Add(lbl_datavencimento);
            Controls.Add(lbl_preco);
            Controls.Add(lbl_nomeproduto);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_cadastro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += FormCadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nud_preco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cadastro;
        private Label lbl_categoria;
        private Label lbl_nomeproduto;
        private Label lbl_preco;
        private Label lbl_datavencimento;
        private Label lbl_observacao;
        private ComboBox cbx_categoria;
        private DateTimePicker dtp_datavencimento;
        private NumericUpDown nud_preco;
        private RichTextBox rtb_observacao;
        private TextBox txt_codigo;
        private TextBox txt_nomeproduto;
        private Button btn_salva;
    }
}