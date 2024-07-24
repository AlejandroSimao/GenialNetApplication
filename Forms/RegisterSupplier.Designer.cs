
namespace GenialNetApplication.Forms
{
    partial class RegisterSupplier
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
            label1 = new System.Windows.Forms.Label();
            txtNameSupplier = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtCpnj = new System.Windows.Forms.TextBox();
            txtCEP = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtAndress = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(58, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do fornecedor";
            // 
            // txtNameSupplier
            // 
            txtNameSupplier.Location = new System.Drawing.Point(196, 52);
            txtNameSupplier.Name = "txtNameSupplier";
            txtNameSupplier.Size = new System.Drawing.Size(196, 23);
            txtNameSupplier.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(58, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "CPNJ";
            // 
            // txtCpnj
            // 
            txtCpnj.Location = new System.Drawing.Point(196, 82);
            txtCpnj.MaxLength = 14;
            txtCpnj.Name = "txtCpnj";
            txtCpnj.Size = new System.Drawing.Size(196, 23);
            txtCpnj.TabIndex = 3;
            txtCpnj.TextChanged += txtCpnj_TextChanged;
            txtCpnj.KeyPress += txtCpnj_KeyPress;
            // 
            // txtCEP
            // 
            txtCEP.Location = new System.Drawing.Point(196, 141);
            txtCEP.MaxLength = 8;
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new System.Drawing.Size(196, 23);
            txtCEP.TabIndex = 7;
            txtCEP.KeyPress += txtCEP_KeyPress;
            txtCEP.Leave += txtCEP_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(58, 149);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "CEP";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(196, 111);
            txtPhone.MaxLength = 17;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(196, 23);
            txtPhone.TabIndex = 5;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(58, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefone";
            // 
            // txtAndress
            // 
            txtAndress.Enabled = false;
            txtAndress.Location = new System.Drawing.Point(196, 170);
            txtAndress.Name = "txtAndress";
            txtAndress.Size = new System.Drawing.Size(196, 23);
            txtAndress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(58, 178);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 15);
            label5.TabIndex = 8;
            label5.Text = "Endereço";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(157, 218);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(137, 43);
            btnSave.TabIndex = 10;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // RegisterSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtAndress);
            Controls.Add(label5);
            Controls.Add(txtCEP);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtCpnj);
            Controls.Add(label2);
            Controls.Add(txtNameSupplier);
            Controls.Add(label1);
            Name = "RegisterSupplier";
            Text = "Cadastro de Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpnj;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAndress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}