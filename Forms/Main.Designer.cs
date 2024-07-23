
namespace GenialNetApplication.Forms
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bntListProducts = new System.Windows.Forms.Button();
            this.btnRegisterSupplier = new System.Windows.Forms.Button();
            this.bntRegisterProd = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.bntListProducts);
            this.panelMenu.Controls.Add(this.btnRegisterSupplier);
            this.panelMenu.Controls.Add(this.bntRegisterProd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // bntListProducts
            // 
            this.bntListProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntListProducts.FlatAppearance.BorderSize = 0;
            this.bntListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntListProducts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntListProducts.Location = new System.Drawing.Point(0, 200);
            this.bntListProducts.Name = "bntListProducts";
            this.bntListProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bntListProducts.Size = new System.Drawing.Size(220, 60);
            this.bntListProducts.TabIndex = 3;
            this.bntListProducts.Text = "Lista de produtos";
            this.bntListProducts.UseVisualStyleBackColor = true;
            this.bntListProducts.Click += new System.EventHandler(this.bntListProducts_Click);
            // 
            // btnRegisterSupplier
            // 
            this.btnRegisterSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterSupplier.FlatAppearance.BorderSize = 0;
            this.btnRegisterSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterSupplier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegisterSupplier.Location = new System.Drawing.Point(0, 140);
            this.btnRegisterSupplier.Name = "btnRegisterSupplier";
            this.btnRegisterSupplier.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRegisterSupplier.Size = new System.Drawing.Size(220, 60);
            this.btnRegisterSupplier.TabIndex = 2;
            this.btnRegisterSupplier.Text = "Cadastro de fornecedores";
            this.btnRegisterSupplier.UseVisualStyleBackColor = true;
            this.btnRegisterSupplier.Click += new System.EventHandler(this.btnRegisterSupplier_Click);
            // 
            // bntRegisterProd
            // 
            this.bntRegisterProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntRegisterProd.FlatAppearance.BorderSize = 0;
            this.bntRegisterProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRegisterProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntRegisterProd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bntRegisterProd.Location = new System.Drawing.Point(0, 80);
            this.bntRegisterProd.Name = "bntRegisterProd";
            this.bntRegisterProd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bntRegisterProd.Size = new System.Drawing.Size(220, 60);
            this.bntRegisterProd.TabIndex = 1;
            this.bntRegisterProd.Text = "Cadastro de produtos";
            this.bntRegisterProd.UseVisualStyleBackColor = true;
            this.bntRegisterProd.Click += new System.EventHandler(this.bntRegisterProd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(580, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(237, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(75, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(580, 370);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button bntListProducts;
        private System.Windows.Forms.Button btnRegisterSupplier;
        private System.Windows.Forms.Button bntRegisterProd;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}