namespace GAME_APP
{
    partial class Game
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
            this.PNLetra = new System.Windows.Forms.Panel();
            this.TXTLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNJogar = new System.Windows.Forms.Button();
            this.PNPalavra = new System.Windows.Forms.Panel();
            this.LBDica = new System.Windows.Forms.Label();
            this.PNLetra.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLetra
            // 
            this.PNLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLetra.Controls.Add(this.TXTLetra);
            this.PNLetra.Controls.Add(this.label1);
            this.PNLetra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PNLetra.Location = new System.Drawing.Point(14, 64);
            this.PNLetra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PNLetra.Name = "PNLetra";
            this.PNLetra.Size = new System.Drawing.Size(359, 136);
            this.PNLetra.TabIndex = 0;
            // 
            // TXTLetra
            // 
            this.TXTLetra.BackColor = System.Drawing.Color.Black;
            this.TXTLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTLetra.ForeColor = System.Drawing.SystemColors.Info;
            this.TXTLetra.Location = new System.Drawing.Point(214, 30);
            this.TXTLetra.MaxLength = 1;
            this.TXTLetra.Name = "TXTLetra";
            this.TXTLetra.Size = new System.Drawing.Size(100, 68);
            this.TXTLetra.TabIndex = 1;
            this.TXTLetra.Text = "A";
            this.TXTLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTLetra_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "LETRA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNJogar
            // 
            this.BTNJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNJogar.Location = new System.Drawing.Point(54, 227);
            this.BTNJogar.Name = "BTNJogar";
            this.BTNJogar.Size = new System.Drawing.Size(303, 67);
            this.BTNJogar.TabIndex = 1;
            this.BTNJogar.Text = "Jogar";
            this.BTNJogar.UseVisualStyleBackColor = true;
            this.BTNJogar.Click += new System.EventHandler(this.BTNJogar_Click);
            // 
            // PNPalavra
            // 
            this.PNPalavra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNPalavra.Location = new System.Drawing.Point(411, 65);
            this.PNPalavra.Name = "PNPalavra";
            this.PNPalavra.Size = new System.Drawing.Size(510, 229);
            this.PNPalavra.TabIndex = 2;
            // 
            // LBDica
            // 
            this.LBDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDica.Location = new System.Drawing.Point(411, 24);
            this.LBDica.Name = "LBDica";
            this.LBDica.Size = new System.Drawing.Size(510, 38);
            this.LBDica.TabIndex = 3;
            this.LBDica.Text = "DICA DA PALAVRA:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(933, 357);
            this.Controls.Add(this.LBDica);
            this.Controls.Add(this.PNPalavra);
            this.Controls.Add(this.BTNJogar);
            this.Controls.Add(this.PNLetra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.Game_Load);
            this.PNLetra.ResumeLayout(false);
            this.PNLetra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNLetra;
        private System.Windows.Forms.TextBox TXTLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNJogar;
        private System.Windows.Forms.Panel PNPalavra;
        private System.Windows.Forms.Label LBDica;
    }
}

