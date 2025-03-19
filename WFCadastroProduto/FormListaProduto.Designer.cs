namespace WFCadastroProduto
{
    partial class FormListaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaProduto));
            dgv_listaproduto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_listaproduto).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaproduto
            // 
            dgv_listaproduto.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_listaproduto.BorderStyle = BorderStyle.Fixed3D;
            dgv_listaproduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaproduto.Dock = DockStyle.Fill;
            dgv_listaproduto.GridColor = SystemColors.InactiveBorder;
            dgv_listaproduto.Location = new Point(0, 0);
            dgv_listaproduto.Name = "dgv_listaproduto";
            dgv_listaproduto.Size = new Size(595, 330);
            dgv_listaproduto.TabIndex = 0;
            // 
            // FormListaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(595, 330);
            Controls.Add(dgv_listaproduto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Produto";
            Load += FormListaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaproduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaproduto;
    }
}