namespace TN01_WFCadastro_novo
{
    partial class FormListagem
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
            dgv_lista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_lista).BeginInit();
            SuspendLayout();
            // 
            // dgv_lista
            // 
            dgv_lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lista.Location = new Point(12, 12);
            dgv_lista.Name = "dgv_lista";
            dgv_lista.Size = new Size(460, 337);
            dgv_lista.TabIndex = 0;
            dgv_lista.CellContentClick += dgv_lista_CellContentClick;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(dgv_lista);
            Name = "FormListagem";
            Text = "Lista de Usuario";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_lista;
    }
}