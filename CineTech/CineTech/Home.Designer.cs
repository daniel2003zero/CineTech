namespace CineTech
{
    partial class Home
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cbxFilme = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinuar.Location = new System.Drawing.Point(25, 344);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(208, 47);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // cbxFilme
            // 
            this.cbxFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilme.FormattingEnabled = true;
            this.cbxFilme.Items.AddRange(new object[] {
            " \'Toy Story\', ",
            " \'Frozen\',",
            " \'Harry Potter\', ",
            " \'Hunger Games\', ",
            " \'Inception\', ",
            " \'The Godfather\', ",
            " \'Casablanca\', ",
            " \'The Bucket List\', ",
            " \'Driving Miss  \'Amour\', "});
            this.cbxFilme.Location = new System.Drawing.Point(25, 142);
            this.cbxFilme.Name = "cbxFilme";
            this.cbxFilme.Size = new System.Drawing.Size(503, 33);
            this.cbxFilme.TabIndex = 4;
            this.cbxFilme.Text = "Escolher Filme";
            this.cbxFilme.SelectedIndexChanged += new System.EventHandler(this.cbxFilme_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(576, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 345);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(20, 25);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(453, 29);
            this.lblBemVindo.TabIndex = 6;
            this.lblBemVindo.Text = "Bem vindo(a), ao nosso app de filmes";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxFilme);
            this.Controls.Add(this.btnContinuar);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.ComboBox cbxFilme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBemVindo;
    }
}

