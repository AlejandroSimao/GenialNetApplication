
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
            panelMenu = new System.Windows.Forms.Panel();
            btnConfig = new System.Windows.Forms.Button();
            bntListProducts = new System.Windows.Forms.Button();
            btnRegisterSupplier = new System.Windows.Forms.Button();
            bntRegisterProd = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            panelTitle = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();
            panelDesktopPane = new System.Windows.Forms.Panel();
            panelMenu.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Controls.Add(bntListProducts);
            panelMenu.Controls.Add(btnRegisterSupplier);
            panelMenu.Controls.Add(bntRegisterProd);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(220, 495);
            panelMenu.TabIndex = 0;
            // 
            // btnConfig
            // 
            btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfig.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnConfig.Location = new System.Drawing.Point(0, 260);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnConfig.Size = new System.Drawing.Size(220, 60);
            btnConfig.TabIndex = 4;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // bntListProducts
            // 
            bntListProducts.Dock = System.Windows.Forms.DockStyle.Top;
            bntListProducts.FlatAppearance.BorderSize = 0;
            bntListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntListProducts.ForeColor = System.Drawing.SystemColors.HighlightText;
            bntListProducts.Location = new System.Drawing.Point(0, 200);
            bntListProducts.Name = "bntListProducts";
            bntListProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            bntListProducts.Size = new System.Drawing.Size(220, 60);
            bntListProducts.TabIndex = 3;
            bntListProducts.Text = "Lista de produtos";
            bntListProducts.UseVisualStyleBackColor = true;
            bntListProducts.Click += bntListProducts_Click;
            // 
            // btnRegisterSupplier
            // 
            btnRegisterSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            btnRegisterSupplier.FlatAppearance.BorderSize = 0;
            btnRegisterSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegisterSupplier.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnRegisterSupplier.Location = new System.Drawing.Point(0, 140);
            btnRegisterSupplier.Name = "btnRegisterSupplier";
            btnRegisterSupplier.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnRegisterSupplier.Size = new System.Drawing.Size(220, 60);
            btnRegisterSupplier.TabIndex = 2;
            btnRegisterSupplier.Text = "Cadastro de fornecedores";
            btnRegisterSupplier.UseVisualStyleBackColor = true;
            btnRegisterSupplier.Click += btnRegisterSupplier_Click;
            // 
            // bntRegisterProd
            // 
            bntRegisterProd.Dock = System.Windows.Forms.DockStyle.Top;
            bntRegisterProd.FlatAppearance.BorderSize = 0;
            bntRegisterProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntRegisterProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bntRegisterProd.ForeColor = System.Drawing.SystemColors.HighlightText;
            bntRegisterProd.Location = new System.Drawing.Point(0, 80);
            bntRegisterProd.Name = "bntRegisterProd";
            bntRegisterProd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            bntRegisterProd.Size = new System.Drawing.Size(220, 60);
            bntRegisterProd.TabIndex = 1;
            bntRegisterProd.Text = "Cadastro de produtos";
            bntRegisterProd.UseVisualStyleBackColor = true;
            bntRegisterProd.Click += bntRegisterProd_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitle.Location = new System.Drawing.Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new System.Drawing.Size(643, 80);
            panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(268, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(75, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new System.Drawing.Size(643, 415);
            panelDesktopPane.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(863, 495);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Name = "Main";
            Text = "Main";
            panelMenu.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button btnConfig;
    }
}