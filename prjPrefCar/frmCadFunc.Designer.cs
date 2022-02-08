namespace prjPrefCar
{
    partial class frmCadFunc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtCargoFunc = new System.Windows.Forms.TextBox();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(35, 82);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(215, 20);
            this.txtNomeFunc.TabIndex = 0;
            // 
            // txtCargoFunc
            // 
            this.txtCargoFunc.Location = new System.Drawing.Point(35, 146);
            this.txtCargoFunc.Name = "txtCargoFunc";
            this.txtCargoFunc.Size = new System.Drawing.Size(215, 20);
            this.txtCargoFunc.TabIndex = 1;
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Location = new System.Drawing.Point(35, 211);
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(215, 20);
            this.txtLoginFunc.TabIndex = 2;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Location = new System.Drawing.Point(35, 273);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.PasswordChar = '*';
            this.txtSenhaFunc.Size = new System.Drawing.Size(215, 20);
            this.txtSenhaFunc.TabIndex = 3;
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Location = new System.Drawing.Point(104, 328);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(75, 23);
            this.btnCadFunc.TabIndex = 4;
            this.btnCadFunc.Text = "Cadastrar";
            this.btnCadFunc.UseVisualStyleBackColor = true;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prefeitura de Itu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha:";
            // 
            // frmCadFunc
            // 
            this.AcceptButton = this.btnCadFunc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 370);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.txtCargoFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtCargoFunc;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

