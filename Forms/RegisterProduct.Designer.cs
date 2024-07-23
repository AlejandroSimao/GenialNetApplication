
namespace GenialNetApplication.Forms
{
    partial class RegisterProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cbxSuppiler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(154, 57);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(180, 23);
            this.txtNameProduct.TabIndex = 1;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(154, 97);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(180, 23);
            this.txtBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // cbxUnit
            // 
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Items.AddRange(new object[] {
            "Unidade",
            "KG",
            "Metro"});
            this.cbxUnit.Location = new System.Drawing.Point(154, 143);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(180, 23);
            this.cbxUnit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione uma UN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço do produto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(490, 57);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 152);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Text = "";
            // 
            // cbxSuppiler
            // 
            this.cbxSuppiler.FormattingEnabled = true;
            this.cbxSuppiler.Location = new System.Drawing.Point(154, 230);
            this.cbxSuppiler.Name = "cbxSuppiler";
            this.cbxSuppiler.Size = new System.Drawing.Size(180, 23);
            this.cbxSuppiler.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fornecedor do produto";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 382);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxSuppiler);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxUnit);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label1);
            this.Name = "RegisterProduct";
            this.Text = "RegisterProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cbxSuppiler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}