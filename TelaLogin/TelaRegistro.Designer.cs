namespace TelaLogin
{
    partial class TelaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRegistro));
            this.registrousuario = new System.Windows.Forms.Label();
            this.senharegistro = new System.Windows.Forms.Label();
            this.emailregistro = new System.Windows.Forms.Label();
            this.usuariorbox = new System.Windows.Forms.TextBox();
            this.senhartext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.termos = new System.Windows.Forms.CheckBox();
            this.realizarregistro = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrousuario
            // 
            this.registrousuario.AutoSize = true;
            this.registrousuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrousuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registrousuario.Location = new System.Drawing.Point(12, 18);
            this.registrousuario.Name = "registrousuario";
            this.registrousuario.Size = new System.Drawing.Size(61, 16);
            this.registrousuario.TabIndex = 0;
            this.registrousuario.Text = "Usuario";
            // 
            // senharegistro
            // 
            this.senharegistro.AutoSize = true;
            this.senharegistro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.senharegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senharegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.senharegistro.Location = new System.Drawing.Point(12, 48);
            this.senharegistro.Name = "senharegistro";
            this.senharegistro.Size = new System.Drawing.Size(51, 16);
            this.senharegistro.TabIndex = 1;
            this.senharegistro.Text = "Senha";
            // 
            // emailregistro
            // 
            this.emailregistro.AutoSize = true;
            this.emailregistro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailregistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailregistro.Location = new System.Drawing.Point(12, 78);
            this.emailregistro.Name = "emailregistro";
            this.emailregistro.Size = new System.Drawing.Size(46, 16);
            this.emailregistro.TabIndex = 3;
            this.emailregistro.Text = "Email";
            // 
            // usuariorbox
            // 
            this.usuariorbox.Location = new System.Drawing.Point(137, 12);
            this.usuariorbox.Name = "usuariorbox";
            this.usuariorbox.Size = new System.Drawing.Size(111, 20);
            this.usuariorbox.TabIndex = 4;
            // 
            // senhartext
            // 
            this.senhartext.Location = new System.Drawing.Point(137, 44);
            this.senhartext.Name = "senhartext";
            this.senhartext.Size = new System.Drawing.Size(111, 20);
            this.senhartext.TabIndex = 5;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(137, 77);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(111, 20);
            this.emailtext.TabIndex = 7;
            // 
            // termos
            // 
            this.termos.AutoSize = true;
            this.termos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.termos.Location = new System.Drawing.Point(91, 113);
            this.termos.Name = "termos";
            this.termos.Size = new System.Drawing.Size(181, 17);
            this.termos.TabIndex = 8;
            this.termos.Text = "Termos e Politica de Privacidade";
            this.termos.UseVisualStyleBackColor = true;
            // 
            // realizarregistro
            // 
            this.realizarregistro.BackColor = System.Drawing.SystemColors.Desktop;
            this.realizarregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.realizarregistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.realizarregistro.Location = new System.Drawing.Point(12, 147);
            this.realizarregistro.Name = "realizarregistro";
            this.realizarregistro.Size = new System.Drawing.Size(111, 23);
            this.realizarregistro.TabIndex = 9;
            this.realizarregistro.Text = "Registrar";
            this.realizarregistro.UseVisualStyleBackColor = false;
            this.realizarregistro.Click += new System.EventHandler(this.realizarregistro_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Desktop;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Location = new System.Drawing.Point(181, 147);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(111, 23);
            this.menu.TabIndex = 10;
            this.menu.Text = "Sair";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TelaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.realizarregistro);
            this.Controls.Add(this.termos);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.senhartext);
            this.Controls.Add(this.usuariorbox);
            this.Controls.Add(this.emailregistro);
            this.Controls.Add(this.senharegistro);
            this.Controls.Add(this.registrousuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRegistro";
            this.Text = "Tela de Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrousuario;
        private System.Windows.Forms.Label senharegistro;
        private System.Windows.Forms.Label emailregistro;
        private System.Windows.Forms.TextBox usuariorbox;
        private System.Windows.Forms.TextBox senhartext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.CheckBox termos;
        private System.Windows.Forms.Button realizarregistro;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}