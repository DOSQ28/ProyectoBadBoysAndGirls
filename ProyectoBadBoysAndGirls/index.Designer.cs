namespace ProyectoBadBoysAndGirls
{
    partial class index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.txtContraseña = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new Guna.UI.WinForms.GunaButton();
            this.pnlogin = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlogin.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BaseColor = System.Drawing.Color.White;
            this.txtContraseña.BorderColor = System.Drawing.Color.Silver;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContraseña.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtContraseña.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContraseña.Font = new System.Drawing.Font("Sitka Banner", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(25, 291);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Radius = 5;
            this.txtContraseña.Size = new System.Drawing.Size(207, 47);
            this.txtContraseña.TabIndex = 47;
            this.txtContraseña.TextOffsetX = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BaseColor = System.Drawing.Color.White;
            this.txtUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txtUsuario.FocusedBorderColor = System.Drawing.Color.Black;
            this.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Font = new System.Drawing.Font("Sitka Banner", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(25, 174);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.Radius = 5;
            this.txtUsuario.Size = new System.Drawing.Size(207, 47);
            this.txtUsuario.TabIndex = 48;
            this.txtUsuario.TextOffsetX = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 39);
            this.label6.TabIndex = 50;
            this.label6.Text = "Contraseña";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseMnemonic = false;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Image = global::ProyectoBadBoysAndGirls.Properties.Resources.boton;
            this.exit.Location = new System.Drawing.Point(498, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(45, 42);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(101, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 81);
            this.pictureBox5.TabIndex = 60;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 39);
            this.label2.TabIndex = 32;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AnimationHoverSpeed = 0.07F;
            this.btnAceptar.AnimationSpeed = 0.03F;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.BorderSize = 3;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(69)))));
            this.btnAceptar.Image = global::ProyectoBadBoysAndGirls.Properties.Resources.outline_done_black_24;
            this.btnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAceptar.Location = new System.Drawing.Point(25, 344);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnAceptar.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnHoverImage = null;
            this.btnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAceptar.Radius = 5;
            this.btnAceptar.Size = new System.Drawing.Size(212, 42);
            this.btnAceptar.TabIndex = 54;
            this.btnAceptar.Text = "INGRESAR";
            this.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlogin
            // 
            this.pnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlogin.BackColor = System.Drawing.Color.White;
            this.pnlogin.Controls.Add(this.pictureBox5);
            this.pnlogin.Controls.Add(this.label6);
            this.pnlogin.Controls.Add(this.btnAceptar);
            this.pnlogin.Controls.Add(this.label2);
            this.pnlogin.Controls.Add(this.txtUsuario);
            this.pnlogin.Controls.Add(this.txtContraseña);
            this.pnlogin.Location = new System.Drawing.Point(128, 41);
            this.pnlogin.Name = "pnlogin";
            this.pnlogin.Size = new System.Drawing.Size(274, 408);
            this.pnlogin.TabIndex = 67;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.gunaPanel2.Controls.Add(this.exit);
            this.gunaPanel2.ForeColor = System.Drawing.Color.Navy;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(543, 42);
            this.gunaPanel2.TabIndex = 65;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoBadBoysAndGirls.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.pnlogin);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlogin.ResumeLayout(false);
            this.pnlogin.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtContraseña;
        private Guna.UI.WinForms.GunaTextBox txtUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox exit;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        internal System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPanel pnlogin;
        private Guna.UI.WinForms.GunaButton btnAceptar;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
    }
}

