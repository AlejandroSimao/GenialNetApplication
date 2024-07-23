
namespace GenialNetApplication.Forms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNot = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(103, 28);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(187, 23);
            this.txtServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(103, 124);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(187, 23);
            this.txtUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seu banco necessita de usuário e senha para conectar?";
            // 
            // rbnYes
            // 
            this.rbnYes.AutoSize = true;
            this.rbnYes.Location = new System.Drawing.Point(103, 84);
            this.rbnYes.Name = "rbnYes";
            this.rbnYes.Size = new System.Drawing.Size(45, 19);
            this.rbnYes.TabIndex = 5;
            this.rbnYes.TabStop = true;
            this.rbnYes.Text = "Sim";
            this.rbnYes.UseVisualStyleBackColor = true;
            this.rbnYes.CheckedChanged += new System.EventHandler(this.rbnYes_CheckedChanged);
            // 
            // rbtnNot
            // 
            this.rbtnNot.AutoSize = true;
            this.rbtnNot.Location = new System.Drawing.Point(219, 83);
            this.rbtnNot.Name = "rbtnNot";
            this.rbtnNot.Size = new System.Drawing.Size(47, 19);
            this.rbtnNot.TabIndex = 6;
            this.rbtnNot.TabStop = true;
            this.rbtnNot.Text = "Não";
            this.rbtnNot.UseVisualStyleBackColor = true;
            this.rbtnNot.CheckedChanged += new System.EventHandler(this.rbtnNot_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(187, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(146, 197);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(96, 27);
            this.btnConect.TabIndex = 9;
            this.btnConect.Text = "Conectar";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 239);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnNot);
            this.Controls.Add(this.rbnYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Configurações do banco de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnYes;
        private System.Windows.Forms.RadioButton rbtnNot;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConect;
    }
}

