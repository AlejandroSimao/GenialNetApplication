namespace GenialNetApplication.Forms
{
    partial class ListProductsinSupplier
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
            datagridProducts = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            cbxSupplier = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)datagridProducts).BeginInit();
            SuspendLayout();
            // 
            // datagridProducts
            // 
            datagridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridProducts.Location = new System.Drawing.Point(53, 59);
            datagridProducts.Name = "datagridProducts";
            datagridProducts.RowTemplate.Height = 25;
            datagridProducts.Size = new System.Drawing.Size(684, 300);
            datagridProducts.TabIndex = 0;
            datagridProducts.CellContentClick += datagridProducts_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de fornecedores";
            // 
            // cbxSupplier
            // 
            cbxSupplier.FormattingEnabled = true;
            cbxSupplier.Location = new System.Drawing.Point(182, 17);
            cbxSupplier.Name = "cbxSupplier";
            cbxSupplier.Size = new System.Drawing.Size(121, 23);
            cbxSupplier.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(360, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(120, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Busca";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(56, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(108, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ListProductsinSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(cbxSupplier);
            Controls.Add(label1);
            Controls.Add(datagridProducts);
            Name = "ListProductsinSupplier";
            Text = "ListProductsinSupplier";
            ((System.ComponentModel.ISupportInitialize)datagridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView datagridProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}