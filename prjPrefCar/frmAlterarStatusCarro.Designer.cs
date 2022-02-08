namespace prjPrefCar
{
    partial class frmAlterarStatusCarro
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
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_EmUso = new System.Windows.Forms.RadioButton();
            this.rdb_Quebrado = new System.Windows.Forms.RadioButton();
            this.rdb_EmConcerto = new System.Windows.Forms.RadioButton();
            this.rdb_Disponivel = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefeitura de Itu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(110, 170);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Modelo.TabIndex = 1;
            this.lbl_Modelo.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_EmUso);
            this.groupBox1.Controls.Add(this.rdb_Quebrado);
            this.groupBox1.Controls.Add(this.rdb_EmConcerto);
            this.groupBox1.Controls.Add(this.rdb_Disponivel);
            this.groupBox1.Location = new System.Drawing.Point(33, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altere o Status do Carro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_EmUso
            // 
            this.rdb_EmUso.AutoSize = true;
            this.rdb_EmUso.Location = new System.Drawing.Point(63, 76);
            this.rdb_EmUso.Name = "rdb_EmUso";
            this.rdb_EmUso.Size = new System.Drawing.Size(62, 17);
            this.rdb_EmUso.TabIndex = 3;
            this.rdb_EmUso.TabStop = true;
            this.rdb_EmUso.Text = "Em Uso";
            this.rdb_EmUso.UseVisualStyleBackColor = true;
            // 
            // rdb_Quebrado
            // 
            this.rdb_Quebrado.AutoSize = true;
            this.rdb_Quebrado.Location = new System.Drawing.Point(63, 99);
            this.rdb_Quebrado.Name = "rdb_Quebrado";
            this.rdb_Quebrado.Size = new System.Drawing.Size(72, 17);
            this.rdb_Quebrado.TabIndex = 2;
            this.rdb_Quebrado.TabStop = true;
            this.rdb_Quebrado.Text = "Quebrado";
            this.rdb_Quebrado.UseVisualStyleBackColor = true;
            // 
            // rdb_EmConcerto
            // 
            this.rdb_EmConcerto.AutoSize = true;
            this.rdb_EmConcerto.Location = new System.Drawing.Point(63, 53);
            this.rdb_EmConcerto.Name = "rdb_EmConcerto";
            this.rdb_EmConcerto.Size = new System.Drawing.Size(85, 17);
            this.rdb_EmConcerto.TabIndex = 1;
            this.rdb_EmConcerto.TabStop = true;
            this.rdb_EmConcerto.Text = "Em Conserto";
            this.rdb_EmConcerto.UseVisualStyleBackColor = true;
            // 
            // rdb_Disponivel
            // 
            this.rdb_Disponivel.AutoSize = true;
            this.rdb_Disponivel.Location = new System.Drawing.Point(63, 30);
            this.rdb_Disponivel.Name = "rdb_Disponivel";
            this.rdb_Disponivel.Size = new System.Drawing.Size(74, 17);
            this.rdb_Disponivel.TabIndex = 0;
            this.rdb_Disponivel.TabStop = true;
            this.rdb_Disponivel.Text = "Disponivel";
            this.rdb_Disponivel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 93);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmAlterarStatusCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterarStatusCarro";
            this.Text = "Alterar Status do Carro";
            this.Load += new System.EventHandler(this.frmAlterarStatusCarro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_EmUso;
        private System.Windows.Forms.RadioButton rdb_Quebrado;
        private System.Windows.Forms.RadioButton rdb_EmConcerto;
        private System.Windows.Forms.RadioButton rdb_Disponivel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}