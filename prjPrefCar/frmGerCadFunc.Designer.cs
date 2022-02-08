namespace prjPrefCar
{
    partial class frmGerCadFunc
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCadastro = new System.Windows.Forms.DataGridView();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnReprovar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prefeitura de Itu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadastros Pendentes:";
            // 
            // dataGridViewCadastro
            // 
            this.dataGridViewCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadastro.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewCadastro.Name = "dataGridViewCadastro";
            this.dataGridViewCadastro.Size = new System.Drawing.Size(534, 202);
            this.dataGridViewCadastro.TabIndex = 8;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(87, 326);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 9;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnReprovar
            // 
            this.btnReprovar.Location = new System.Drawing.Point(372, 326);
            this.btnReprovar.Name = "btnReprovar";
            this.btnReprovar.Size = new System.Drawing.Size(75, 23);
            this.btnReprovar.TabIndex = 10;
            this.btnReprovar.Text = "Reprovar";
            this.btnReprovar.UseVisualStyleBackColor = true;
            this.btnReprovar.Click += new System.EventHandler(this.btnReprovar_Click);
            // 
            // frmGerCadFunc
            // 
            this.AcceptButton = this.btnAceitar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 370);
            this.Controls.Add(this.btnReprovar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.dataGridViewCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGerCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Cadastros";
            this.Load += new System.EventHandler(this.frmGerCadFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCadastro;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnReprovar;
    }
}