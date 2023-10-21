namespace TelaLogin
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.bemvindo = new System.Windows.Forms.Label();
            this.termos = new System.Windows.Forms.CheckBox();
            this.boxsenha = new System.Windows.Forms.TextBox();
            this.boxlogin = new System.Windows.Forms.TextBox();
            this.logintext = new System.Windows.Forms.Label();
            this.senhatext = new System.Windows.Forms.Label();
            this.bg = new System.Windows.Forms.PictureBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonregistro = new System.Windows.Forms.Button();
            this.pictureBoxolho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxolho)).BeginInit();
            this.SuspendLayout();
            // 
            // bemvindo
            // 
            this.bemvindo.AutoSize = true;
            this.bemvindo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bemvindo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bemvindo.Font = new System.Drawing.Font("Gabriola", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bemvindo.ForeColor = System.Drawing.SystemColors.Control;
            this.bemvindo.Location = new System.Drawing.Point(92, 9);
            this.bemvindo.Name = "bemvindo";
            this.bemvindo.Size = new System.Drawing.Size(638, 97);
            this.bemvindo.TabIndex = 0;
            this.bemvindo.Text = "Seja Bem Vindo a Nossa Plataforma";
            this.bemvindo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // termos
            // 
            this.termos.AutoSize = true;
            this.termos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.termos.Location = new System.Drawing.Point(374, 300);
            this.termos.Name = "termos";
            this.termos.Size = new System.Drawing.Size(258, 20);
            this.termos.TabIndex = 3;
            this.termos.Text = "Termos e Politica de Privacidade";
            this.termos.UseVisualStyleBackColor = true;
            // 
            // boxsenha
            // 
            this.boxsenha.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.boxsenha.Location = new System.Drawing.Point(405, 208);
            this.boxsenha.Name = "boxsenha";
            this.boxsenha.Size = new System.Drawing.Size(150, 20);
            this.boxsenha.TabIndex = 4;
            // 
            // boxlogin
            // 
            this.boxlogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.boxlogin.Location = new System.Drawing.Point(405, 169);
            this.boxlogin.Name = "boxlogin";
            this.boxlogin.Size = new System.Drawing.Size(150, 20);
            this.boxlogin.TabIndex = 5;
            // 
            // logintext
            // 
            this.logintext.AutoSize = true;
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logintext.Location = new System.Drawing.Point(334, 173);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(45, 16);
            this.logintext.TabIndex = 6;
            this.logintext.Text = "Login";
            // 
            // senhatext
            // 
            this.senhatext.AutoSize = true;
            this.senhatext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhatext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.senhatext.Location = new System.Drawing.Point(334, 212);
            this.senhatext.Name = "senhatext";
            this.senhatext.Size = new System.Drawing.Size(51, 16);
            this.senhatext.TabIndex = 7;
            this.senhatext.Text = "Senha";
            // 
            // bg
            // 
            this.bg.Location = new System.Drawing.Point(4, 102);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(324, 336);
            this.bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg.TabIndex = 8;
            this.bg.TabStop = false;
            this.bg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonlogin.Location = new System.Drawing.Point(389, 255);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 9;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click_1);
            // 
            // buttonregistro
            // 
            this.buttonregistro.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonregistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonregistro.Location = new System.Drawing.Point(498, 255);
            this.buttonregistro.Name = "buttonregistro";
            this.buttonregistro.Size = new System.Drawing.Size(75, 23);
            this.buttonregistro.TabIndex = 10;
            this.buttonregistro.Text = "Registrar";
            this.buttonregistro.UseVisualStyleBackColor = false;
            this.buttonregistro.Click += new System.EventHandler(this.buttonregistro_Click_1);
            // 
            // pictureBoxolho
            // 
            this.pictureBoxolho.Location = new System.Drawing.Point(561, 208);
            this.pictureBoxolho.Name = "pictureBoxolho";
            this.pictureBoxolho.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxolho.TabIndex = 12;
            this.pictureBoxolho.TabStop = false;
            this.pictureBoxolho.Click += new System.EventHandler(this.pictureBoxolho_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxolho);
            this.Controls.Add(this.buttonregistro);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.senhatext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.boxlogin);
            this.Controls.Add(this.boxsenha);
            this.Controls.Add(this.termos);
            this.Controls.Add(this.bemvindo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Login";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Tela_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxolho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bemvindo;
        private System.Windows.Forms.CheckBox termos;
        private System.Windows.Forms.TextBox boxsenha;
        private System.Windows.Forms.TextBox boxlogin;
        private System.Windows.Forms.Label logintext;
        private System.Windows.Forms.Label senhatext;
        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonregistro;
        private System.Windows.Forms.PictureBox pictureBoxolho;
    }
}

