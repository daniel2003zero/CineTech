namespace CineTech
{
    partial class TelaAssistir
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.cbxFilme = new System.Windows.Forms.ComboBox();
            this.btnAssistirAgora = new System.Windows.Forms.Button();
            this.mtxData = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(12, 35);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(453, 29);
            this.lblBemVindo.TabIndex = 7;
            this.lblBemVindo.Text = "Bem vindo(a), ao nosso app de filmes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(579, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 345);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVer.Location = new System.Drawing.Point(17, 278);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(208, 47);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Quero ver este";
            this.btnVer.UseVisualStyleBackColor = false;
            // 
            // cbxFilme
            // 
            this.cbxFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilme.FormattingEnabled = true;
            this.cbxFilme.Location = new System.Drawing.Point(17, 206);
            this.cbxFilme.Name = "cbxFilme";
            this.cbxFilme.Size = new System.Drawing.Size(455, 47);
            this.cbxFilme.TabIndex = 10;
            this.cbxFilme.Text = "A volta dos que não foram";
            // 
            // btnAssistirAgora
            // 
            this.btnAssistirAgora.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAssistirAgora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssistirAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAssistirAgora.Location = new System.Drawing.Point(17, 495);
            this.btnAssistirAgora.Name = "btnAssistirAgora";
            this.btnAssistirAgora.Size = new System.Drawing.Size(208, 47);
            this.btnAssistirAgora.TabIndex = 13;
            this.btnAssistirAgora.Text = "Assistir agora!";
            this.btnAssistirAgora.UseVisualStyleBackColor = false;
            this.btnAssistirAgora.Click += new System.EventHandler(this.btnAssistirAgora_Click);
            // 
            // mtxData
            // 
            this.mtxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxData.Location = new System.Drawing.Point(17, 439);
            this.mtxData.Mask = "00/00/0000";
            this.mtxData.Name = "mtxData";
            this.mtxData.Size = new System.Drawing.Size(245, 31);
            this.mtxData.TabIndex = 15;
            this.mtxData.ValidatingType = typeof(System.DateTime);
            this.mtxData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxData_MaskInputRejected);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(17, 384);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 31);
            this.textBoxNome.TabIndex = 16;
            // 
            // TelaAssistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 554);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.mtxData);
            this.Controls.Add(this.btnAssistirAgora);
            this.Controls.Add(this.cbxFilme);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "TelaAssistir";
            this.Text = "TelaAssistir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cbxFilme;
        private System.Windows.Forms.Button btnAssistirAgora;
        private System.Windows.Forms.MaskedTextBox mtxData;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}